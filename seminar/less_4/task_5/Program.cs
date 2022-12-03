// Решение в группах задач:
// Задача 3: Напишите программу, которая выводит
// массив из n элементов, заполненный числами в случайном порядке.

//функция ввода массива
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
int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");
int[] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
