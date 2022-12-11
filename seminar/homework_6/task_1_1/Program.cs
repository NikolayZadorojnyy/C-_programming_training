// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// функция ввода пользователем определенного количества чисел с консоли
int[] EnterTheNumber()
{
    System.Console.Write("Введите колличество чисел: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] number = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        number[i] = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

// функция подсчета количества положительных чисел массива
int PositiveCount(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        } 
    }
    return count;
}

int[] value = EnterTheNumber();
int result = PositiveCount(value);
Console.WriteLine($"Положительных чисел: {result}");
