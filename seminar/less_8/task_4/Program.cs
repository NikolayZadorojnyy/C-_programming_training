// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] CreateFillArray(int m)
{
    int[,] array = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
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

// Метод находит мин. элемент массива на пересечении
// строки и столбца
(int, int) FindMinIJ(int[,] matrix)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minI, minJ] > matrix[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    return (minI, minJ);
}

// метод удаляет строку и столбец на пересечении которых
// находится минимальный элемент
int[,] DeleteIJ(int[,] array, int I, int J)
{
    int rows = 0;
    int columns = 0;
    int[,] matrix = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        columns = 0;
        if (I == i) continue;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (J == j) continue;
            matrix[rows, columns] = array[i, j];
            columns++;
        }
        rows++;

    }
    return matrix;
}

int[,] matrix = CreateFillArray(5);
PrintArray(matrix);
System.Console.WriteLine();
(int A, int B) = FindMinIJ(matrix);
PrintArray(DeleteIJ(matrix, A, B));