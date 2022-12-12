// **Задача 3.** Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца:
// 4,6; 5,6; 3,6; 3.

//ввод данных
int Prompt(string message)
{
    Console.Write($"{message} ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

//создание массива
int[,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

//печать  массива
void PrintArrayTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

// метод выводит среднее арифметическое значение по столбцам в матрице
void AvgElementColumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        Console.Write($"{sum / matr.GetLength(0)} ");
    }
    Console.ReadLine();
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");
int[,] matrix = FillCreateArray(m, n);
PrintArrayTwo(matrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
AvgElementColumn(matrix);