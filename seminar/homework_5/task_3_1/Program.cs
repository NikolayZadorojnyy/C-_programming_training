// **Задача 3:** Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// генерация массива вещественных чисел
double[] GenerateArray(int Length, int minRange, int maxRange)
{
    double[] array = new double[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(minRange, maxRange);
    }
    return array;
}

// вывод массива вещественных чисел
void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        double c = array[j];
        c = Math.Round(c, 2); // форматируем вывод 2 знака после запятой
        Console.Write(c + "  ");
    }
    Console.WriteLine();
}

// функция ввода параметров массива
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод находит разницу междеу максимальным и минимальным значением
double MaxMinusMin(double[] Array, int Length)
{
    double result = 0;
    double max = Array[0];
    double min = Array[0];
    for (int i = 1; i < Length; i++)
    {
        if (Array[i] < min)
            min = Array[i];
        if (Array[i] > max)
            max = Array[i];
    }
    result = max - min;
    return result = Math.Round(result, 2); //форматир вывода
}

int Length = Promt("Введите длину массива ");
int minArray = Promt("Введите минимальное значение ");
int maxArray = Promt("Введите максимальное значение ");

double[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);
MaxMinusMin(array, Length);
System.Console.WriteLine($"Макс. элемент минус мин. элемент = {MaxMinusMin(array, Length)}");