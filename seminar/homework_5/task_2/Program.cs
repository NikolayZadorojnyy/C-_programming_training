// **Задача 2:** Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
    Console.WriteLine();
}

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод находит сумму элементов на нечетных позициях
int SummOddIndex(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i += 2)
    {
        sum += Array[i];
    }
    return sum;
}

int Length = Promt("Введите длину массива ");
int minArray = Promt("Введите минимальное значение ");
int maxArray = Promt("Введите максимальное значение ");

int[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов на нечётных позициях = {SummOddIndex(array)}");