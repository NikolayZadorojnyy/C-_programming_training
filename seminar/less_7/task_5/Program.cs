// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

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
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

(int?, int?) SearchElement(int[,] matr, int SearchEl)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (SearchEl == matr[i, j])
            {
                return (i, j);
            }
        }
    }
    return (null, null);
}
int rows = Prompt("Input number of rows > ");
int coloums = Prompt("Input number of coloums > ");
int[,] Array = FillCreateArray(rows, coloums);
PrintArray(Array);
int SeachEl = Prompt("Input element > ");
(int? FoundedRow, int? FoundedColoumn) = SearchElement(Array, SeachEl);

if (FoundedRow == null)
{
    Console.WriteLine($"Element is not founded");
}
else Console.WriteLine($"Row and Coloumn is {FoundedRow} and {FoundedColoumn}");
