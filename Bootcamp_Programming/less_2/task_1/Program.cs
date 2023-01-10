using System.Diagnostics;

// Задать массив натуральных чисел. Найти наибольшую сумму
// трех элементов массива подряд.
// [1,2.5.1.5.6.4.8.9.3]
// m = 3
// MAX => 21

int size = 200000; // размер массива
int m = 1000;     // сумма скольки элементов
// создание и наполнение массива
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
if (m > 20 || size > 20)           // если большой массив - не выводим его
    System.Console.WriteLine($"задан массив из {size} элементов.");
else
    System.Console.WriteLine($"задан массив:[{string.Join(", ", array)}]");

// метод 1 для нахождения макс суммы m элементов 
// массива расположенных подряд (медленный так как цикл в цикле)
int MaxIntervalArray(int[] arr, int interval)
{
    int max = 0;
    for (int i = 0; i < arr.Length - interval; i++)
    {
        int t = 0;
        for (int j = i; j < i + interval; j++) // каждый раз в цикле считаем сумму m элементов
        {
            t = t + arr[j];
        }
        if (t > max) max = t;
    }
    return max;
}

// метод 2 для нахождения макс суммы m элементов  массива 
// расположенных подряд (быстрый так как по факту практически один цикл)
int MaxIntervalArr(int[] arr, int interval)
{
    int max = 0;
    for (int j = 0; j < interval; j++) max += arr[j]; // находим сумму первых m элементов
    int t = max;
    for (int i = 1; i < arr.Length - interval; i++)
    {                                                   // каждый раз в цикле к сумме 
        t = t - arr[i - 1] + arr[i + (interval - 1)]; // первых m элементов прибавляем
        if (t > max) max = t;                       // и отнимаем по одному значению
    }
    return max;
}

Stopwatch sw1 = new(); // объект для подсчета времени выполнения первым способом
sw1.Start();
Console.Write($"макс. сумма {m} элементов подряд равна {MaxIntervalArray(array, m)}");
sw1.Stop();
System.Console.WriteLine($" => время выполнения метода 1: {sw1.ElapsedMilliseconds} мс. ");

Stopwatch sw2 = new(); // объект для подсчета времени выполнения вторым способом
sw2.Start();
Console.Write($"макс. сумма {m} элементов подряд равна {MaxIntervalArr(array, m)}");
sw2.Stop();
System.Console.WriteLine($" => время выполнения метода 2: {sw2.ElapsedMilliseconds} мс. ");
