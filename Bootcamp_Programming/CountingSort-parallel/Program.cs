// сортировка подсчетом с организацией паралельных вычислений и без
// если закоментировать локер стр. 70,71,73 то наблюдаем гонку потоков

const int THREADS_NUMBER = 4; //число потоков
const int N = 1000000; //размер массива
object lock_object = new object(); // создаем объект для блокировки чтобы избежать гонки потоков

// создание рандомного массива одной строкой
Random rand = new Random();
int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray();
int[] resParallel = new int[N];
// копированием создаем еще один массив (каждый для своего метода сортировки)
Array.Copy(resSerial, resParallel, N);
// Console.WriteLine(string.Join(", ", resSerial));

CountingSortExtended(resSerial);
PrepareParallelCountingSort(resParallel);
Console.WriteLine(EqualityMatrix(resSerial, resParallel));
// Console.WriteLine(string.Join(", ", resSerial));
// Console.WriteLine(string.Join(", ", resParallel));

void PrepareParallelCountingSort(int[] inputArray)
{
  int max = inputArray.Max(); // находим макс и мин массива
  int min = inputArray.Min();

  int offset = -min; // смещение для правильного формирования каунтера 
  int[] counters = new int[max + offset + 1]; // создаем массив возможных вариантов

  int eachThreadCalc = N / THREADS_NUMBER; // задаем общий объем операций для потока
  var threadsParall = new List<Thread>();

  for (int i = 0; i < THREADS_NUMBER; i++)
  {
    int startPos = i * eachThreadCalc; // распределяем нагрузку равномерно по потокам
    int endPos = (i + 1) * eachThreadCalc;
    if (i == THREADS_NUMBER - 1) endPos = N; // на последний поток кидаем остатки нагрузки
    threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, offset, startPos, endPos)));
    threadsParall[i].Start(); // запуск потоков
  }

  foreach (var thread in threadsParall)
  {
    thread.Join(); // сбрасываем отработанные потоки в общий поток
  }

  int index = 0;
  for (int i = 0; i < counters.Length; i++)
  {
    for (int j = 0; j < counters[i]; j++)
    {
      inputArray[index] = i - offset;
      index++;
    }
  }
}

// параллельная сортировка части массива
void CountingSortParallel(int[] inputArray, int[] counters, int offset, int startPos, int endPos)
{
  for (int i = startPos; i < endPos; i++)
  {
    lock (lock_object) // ставим блокировку чтобы потоки не могли одновременно писать в одну ячейку
    {
      counters[inputArray[i] + offset]++;
    }
  }
}

// сортировка подсчетом последовательная без потоков
void CountingSortExtended(int[] inputArray)
{
  int max = inputArray.Max();
  int min = inputArray.Min();

  int offset = -min;
  int[] counters = new int[max + offset + 1];


  for (int i = 0; i < inputArray.Length; i++)
  {
    counters[inputArray[i] + offset]++;
  }

  int index = 0;
  for (int i = 0; i < counters.Length; i++)
  {
    for (int j = 0; j < counters[i]; j++)
    {
      inputArray[index] = i - offset;
      index++;
    }
  }
}

// при больших данных покажет гонку потоков (false) если убрать локер
bool EqualityMatrix(int[] fmatrix, int[] smatrix)
{
  bool res = true;

  for (int i = 0; i < N; i++)
  {
    res = res && (fmatrix[i] == smatrix[i]);
  }

  return res;
}