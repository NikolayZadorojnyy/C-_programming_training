// Задача 3: Напишите программу вычисления функции Аккермана с
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// ввод данных
int Prompt(string message)
{
    Console.Write($"{message} > ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());  // ввод числа
}

// рекурсивный метод рассчета функции Аккермана
int FunkAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return FunkAkkerman(m - 1, 1);
    else
        return FunkAkkerman(m - 1, FunkAkkerman(m, n - 1));
}

int numberStart = Prompt("Введите число M ");
int numberFinish = Prompt("Введите число N ");
System.Console.Write("Функция Аккермана равна: ");
Console.WriteLine(FunkAkkerman(numberStart, numberFinish));


