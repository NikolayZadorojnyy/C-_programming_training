// **Задача 2:** Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

// ввод данных
int Prompt(string message)
{
    Console.Write($"{message} > ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

// рекурсивный метод нахождения суммы натуральных чисел в диапазоне
int SumNumberInterval(int numberStart, int numberFinish)
{
    if (numberStart > numberFinish)
        return 0;
    return numberStart + SumNumberInterval(numberStart + 1, numberFinish);
}

int numberStart = Prompt("Введите натуральное число M "); ;
int numberFinish = Prompt("Введите натуральное число N "); ;
System.Console.Write("Сумма натуральных чисел, расположенных между M и N : ");

int sum = SumNumberInterval(numberStart, numberFinish);
System.Console.Write($"{sum} ");