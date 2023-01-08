// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write($"{message} "); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

// функция подсчета положительных чисел введенных пользователем
int PositiveCount(int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        int x = Prompt($"Введите число {i + 1}: ");
        if (x > 0)
            count++;
    }
    return count;
}

int result = PositiveCount(Prompt("Введите колличество чисел: "));
Console.WriteLine($"Положительных чисел: {result}");
