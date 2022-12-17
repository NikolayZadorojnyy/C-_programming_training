// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 1 | 3 4
// 3 2 1 | 3 3
// _ _ _ | 1 1
// Результирующая матрица будет:
// 19 21
// 16 19

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

// метод для умножения матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception(@"Умножение не возможно! Количество столбцов 
        первой матрицы не равно количеству строк второй матрицы.");
    }
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}


int m1 = Prompt("Введите количество строк первой матрицы > ");
int n1 = Prompt("Введите колличество столбцов первой матрицы > ");
int m2 = Prompt("Введите количество строк второй матрицы > ");
int n2 = Prompt("Введите колличество столбцов второй матрицы > ");
int[,] namberOneMatrix = FillCreatematr(m1, n1);
PrintmatrTwo(namberOneMatrix);
System.Console.WriteLine();
int[,] namberTwoMatrix = FillCreatematr(m2, n2);
PrintmatrTwo(namberTwoMatrix);
System.Console.WriteLine();
PrintmatrTwo(MatrixMultiplication(namberOneMatrix, namberTwoMatrix));


