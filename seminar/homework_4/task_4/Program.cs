// Задача *: Напишите программу,
// которая из массива случайных чисел. Ищет второй максимум
//  (число меньше максимального элемента, но больше всех остальных).
//   Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

//функция ввода массива случайных чисел с заданными параметрами
int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

// функция вывода массива
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

// функция ввода параметров
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// функция нахожления второго максимума в массиве
int SecondMaxElement(int[] array)
{
    int max1 = 0;
    int max2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max1 < array[i])
        {
            max2 = max1;
            max1 = array[i];
        }
        else if (max2 < array[i])
        {
            max2 = array[i];
        }
    }
    return max2;
}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");

int[] arr = GenerateArray(Range, minValue, maxValue);

PrintArray(arr);

Console.WriteLine("Второй максимум массива равен: " + SecondMaxElement(arr));