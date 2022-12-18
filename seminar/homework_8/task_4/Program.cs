// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
            System.Console.Write(String.Format("{0,3}",matr[j,i]));
        }
        System.Console.WriteLine();
    }
}

// метод заполнения матрицы по спирали
int[,] Fill(int[,] array)
{
    var SizeX = array.GetUpperBound(0);
    var SizeY = array.GetUpperBound(1);
    var maxX = SizeX + 1;
    var maxY = SizeY;
    var dirX = 1;
    var dirY = 1;

    var x = -1;
    var y = 0;
    var val = 1;
    while ((maxX >= 0) && (maxY >= 0))
    {
        for (int xval = 1; xval <= maxX; xval++)
        {
            array[x + dirX * xval, y] = val;
            val++;
        }

        x = x + dirX * maxX;
        dirX = -dirX;
        maxX--;

        for (int yval = 1; yval <= maxY; yval++)
        {
            array[x, y + dirY * yval] = val;
            val++;
        }

        y = y + dirY * maxY;
        dirY = -dirY;
        maxY--;
    }

    return array;
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");
int[,] matrix = FillCreatematr(m, n);
PrintmatrTwo(matrix);
System.Console.WriteLine();
PrintmatrTwo(Fill(matrix));




