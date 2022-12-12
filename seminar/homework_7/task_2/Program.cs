// **Задача 2.** Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//   что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1Колонка > 7
// 1, 7 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write($"{message} ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArrayTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// метод выводит значение по заданным координатам в матрице
void MatrixElementSearch(int[,] matr, int posRows, int posColumn)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++){}
    }
    if (posRows < 0 | posRows > matr.GetLength(0) - 1 | posColumn < 0 | posColumn > matr.GetLength(1) - 1)
    {
        Console.WriteLine($"Элемент ряд {posRows} колонка {posColumn} не существует");
    }
    else
        Console.WriteLine($"Значение элемента {posRows},{posColumn} массива = {matr[posRows, posColumn]}");
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");
int posRow = Prompt("Введите номер строки > ");
int posColum = Prompt("Введите номер столбца > ");

int[,] matrix = FillCreateArray(m, n);
PrintArrayTwo(matrix);
MatrixElementSearch(matrix, posRow, posColum);