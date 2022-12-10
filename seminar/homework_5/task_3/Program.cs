// **Задача 3:** Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Length = Promt("Введите длину массива ");
double[] array = new double[Length]; // инициализация массива double
double max = 0;
double min = 0;
for (int i = 0; i < Length; i++)
{
    Console.Write("Введите число {0}: ", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
//Находим минимум и максимум
min = array[0];
max = array[0];
for (int i = 1; i < Length; i++)
{
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}

Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine($"Max - Min =  {max - min}");

