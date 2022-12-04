﻿// Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// генерация массива
int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

// вывод массива
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    Console.WriteLine();
}

// ввод данных с консоли
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// функция поиска количества элементов принадлежащих заданному отрезку
int Search(int[] array, int minLine, int maxLine)
{
    int counter = 0;
    foreach (int item in array)
    {
        if (item >= minLine && item <= maxLine)
        {
            counter++;
        }
    }
    return counter;
}

int Length = Promt("Input length of array ");
int minArray = Promt("Input min of array ");
int maxArray = Promt("Input max of array ");

int[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);

int minLine = Promt("Ввелите начало числового отрезка ");
int maxLine = Promt("Ввелите конец числового отрезка ");

System.Console.WriteLine($"Кол. эл. принад. отрезку {Search(array, minLine, maxLine)}");
