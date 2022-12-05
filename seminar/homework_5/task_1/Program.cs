// **Задача 1**: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
    Console.WriteLine();
}

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// функция считает количество четных чисел
int EvenNumber(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] %2 == 0)
        {
          count = count +1;
        }
    }
    return count;
}

int Length = Promt("Введите длину массива ");
int minArray = 100;
int maxArray = 1000;

int[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве = {EvenNumber(array)}");