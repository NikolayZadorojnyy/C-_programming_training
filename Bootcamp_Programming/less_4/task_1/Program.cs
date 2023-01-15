/* алгоритм сортировка выбором MIN - MAX

Начальный массив: [3, 1, 6, 2, 8, 4]
[1, 3, 6, 2, 8, 4] шаг 1
[1, 2, 6, 3, 8, 4] шаг 2
[1, 2, 3, 6, 8, 4] шаг 3
[1, 2, 3, 4, 8, 6] шаг 4
[1, 2, 3, 4, 6, 8] шаг 5
Конечный массив: [1, 2, 3, 4, 6, 8]
*/

Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

// Cортировка
for (int i = 0; i < n - 1; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[MinIndex])
            MinIndex = j;
    }
    int temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
    Console.WriteLine("[" + string.Join(", ", array) + "] шаг "+ (i+1));
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");


