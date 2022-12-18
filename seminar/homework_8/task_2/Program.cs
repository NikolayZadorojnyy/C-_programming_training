// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

//ввод данных
int Prompt(string message)
{
    Console.Write($"{message} ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

//создание массива
int[,] FillCreatematr(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

//печать  массива
void PrintmatrTwo(int[,] matr)
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

// метод считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов
int SumElementRows(int[,] matr, int m, int n)
{
    int minRowSum = int.MaxValue;
    int indexMinRow = 0;
    for (int i = 0; i < m; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < n; j++)
            rowSum += matr[i, j];

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }

    }
    return indexMinRow;
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");
int[,] matrix = FillCreatematr(m, n);
PrintmatrTwo(matrix);


System.Console.WriteLine(
    $"Строка с наименьшей суммой элементов: {SumElementRows(matrix,m,n)}");
