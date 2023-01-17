// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// функция нахождения произведения пар чисел начиная первого и последнего элемента
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    Console.WriteLine();
}

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Multi(int[] Array)
{
    int[] result = new int [Array.Length/2 + Array.Length%2];
    result[result.Length - 1]=Array[result.Length - 1];
    for (int i=0; i < Array.Length/2; i++)
    {
        result[i] = Array[i] * Array[Array.Length - 1 - i];
    }
    return result;
}

int Length = Promt("Введите длину массива ");
int minArray = Promt("Введите минимальное значение ");
int maxArray = Promt("Введите максимальное значение ");

int[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);
PrintArray(Multi(array));
// System.Console.WriteLine($"Count of numbers is {Multi(array)}");
Console.ReadKey();