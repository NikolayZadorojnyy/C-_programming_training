// Задача 5: * Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. Затем найдите минимальное значение по
// каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами)
// вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

// Функция заполнения двухмерного массива случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

// Функция вывода двухмерного массива на печать в виде таблицы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // получаем длину строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // получаем длину столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// функция нахождения суммы максимумов по строкам матрицы
int SummOfMaxInRows(int[,] matr)
{
    int sumMaxRows = 0;
    int maxRows = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        maxRows = matr[i, 0];
        for (int j = 1; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > maxRows) maxRows = matr[i, j];
        }
        sumMaxRows = sumMaxRows + maxRows;
    }
    return sumMaxRows;
}

// функция нахождения суммы минимумов по колонкам матрицы
int SummOfMinInColumn(int[,] matr)
{
    int sumMinColumn = 0;
    int minColumn = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minColumn = matr[0, j];
        for (int i = 1; i < matr.GetLength(0); i++)
        {
            if (matr[i, j] < minColumn) minColumn = matr[i, j];
        }
        sumMinColumn = sumMinColumn + minColumn;
    }
    return sumMinColumn;
}

int[,] matrix = new int[3, 8];
FillArray(matrix);
PrintArray(matrix);
int sumMax = SummOfMaxInRows(matrix);
int sumMin = SummOfMinInColumn(matrix);
System.Console.WriteLine($"Сумма максимумов по строкам: {sumMax}");
System.Console.WriteLine($"Сумма минимумов по столбцам: {sumMin}");
System.Console.WriteLine($"Сумма максимумов минус сумма минимумов: {sumMax - sumMin}");