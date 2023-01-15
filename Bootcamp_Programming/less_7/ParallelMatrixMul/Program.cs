const int N = 1000; //размер матрицы
const int THREADS_NUMBER = 10; // количество потоков

int[,] serialMulRes = new int[N, N]; //результат выполнения умножения матриц в однопотоке
int[,] threadMulRes = new int[N, N]; //результат параллельного умножения матриц

int[,] firstMatrix = MatrixGenerator(N, N); // заполняем матрицы
int[,] secondMatrix = MatrixGenerator(N, N);

SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));


// метод заполнения матриц случайными числами
int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}
// метод последовательного умножения матриц
void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}
// разбиваем на потоки для вычисления а затем объединяем потоки
void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    int eachThreadCalc = N / THREADS_NUMBER; // количество вычислений на поток
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>(); // создаем коллекцию потоков
    for (int i = 0; i < THREADS_NUMBER; i++) // разбиваем на потоки
    {
        int startPos = i * eachThreadCalc;  // позиция для старта потока
        int endPos = (i + 1) * eachThreadCalc;  // позиция для окончания потока
        //если последний поток
        if (i == THREADS_NUMBER - 1) endPos = N; // остатки от деления потоков кидаем на последний поток
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos))); // заполняем коллекцию потоков
        threadsList[i].Start(); // старт заполнения
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join(); // результат вычислений отдельного потока присоединяем к главному потоку
    }
}
//  метод параллельное умножения матриц с параметрами старта и конца потока
void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}
// метод сравнения двух матриц
bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)
{
    bool res = true;

    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }

    return res;
}



