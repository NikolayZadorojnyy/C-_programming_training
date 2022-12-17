﻿// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateFillArray(int m,int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            System.Console.Write($"{list[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
// метод заменяет строки на столбцы если их количество одинаковое
int[,] Transpon(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int Number = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = Number;
        }

    }
    return matrix;
}

int[,] list = CreateFillArray(4,4);
PrintArray(list);
System.Console.WriteLine();
if (list.GetLength(0) == list.GetLength(1))
PrintArray(Transpon(list));
else
System.Console.WriteLine("Невозможно заменить строки на столбцы");



