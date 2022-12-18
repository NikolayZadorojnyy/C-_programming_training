// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// метод пузырьковой сортировки одномерного массива по убыванию
void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

// формирование массива после сортировки по строке или столбцу
void Insert(bool isRow, int count, int[] rowColumnSort, int[,] matr)
{
    for (int k = 0; k < rowColumnSort.Length; k++)
    {
        if (isRow)
            matr[count, k] = rowColumnSort[k];
        else
            matr[k, count] = rowColumnSort[k];
    }
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");
int[,] matrix = FillCreateArray(m, n);
Console.WriteLine("Исходный массив: ");
PrintArrayTwo(matrix);
Console.WriteLine("После сортировки по строке: ");
int[] row = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        row[j] = matrix[i, j];
    BubbleSort(row); 
    Insert(true, i, row, matrix); 
}
PrintArrayTwo(matrix);
