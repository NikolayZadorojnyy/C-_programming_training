// Задача 3: Напишите программу, которая выводит массив из 8 элементов,
// заполненный случайными числами. Оформите заполнение массива и вывод в
// виде функции (пригодится в следующих задачах). Реализовать через функции.
//  (* Доп сложность, “введите количество элементов массива”, “Введите минимальный
//  порог случайных значений”, “Введите максимальный порог случайных значений”)

//функция ввода массива
int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

// функция вывода массива
void PrintArray(int[] array, int printout)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (printout == 1)
        {
            Console.WriteLine(array[j] + " ");
        }
        else
        {
            Console.Write(array[j] + " ");
        }
    }
}

// функция ввода параметров
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Range = Promt("Введите длину массива > ");
int minValue = Promt("Введите минимальное значение > ");
int maxValue = Promt("Введите максимальное значение > ");
int[] arr = GenerateArray(Range, minValue, maxValue);
int RowColumn = Promt("Для вывода: 1 - столбец, другая цифра - строка > ");
PrintArray(arr, RowColumn);
