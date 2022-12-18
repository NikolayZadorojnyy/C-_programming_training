// **Задача 1:** Задайте значения M и N. Напишите программу, которая
// выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"M = 4; N = 8 -> "4, 6, 8"

// ввод данных
int Prompt(string message)
{
    Console.Write($"{message} > ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

// рекурсивный метод нахождения целых четных чисел в диапазоне
void PrintEvenNumber(int numberStart, int numberFinish)
{
    if (numberStart == numberFinish)
        return;
    if (numberStart % 2 == 0)
        System.Console.Write($"{numberStart} ");
    PrintEvenNumber(numberStart + 1, numberFinish); // рекурсивный вызов метода
}

int numberStart = Prompt("Введите число M "); ;
int numberFinish = Prompt("Введите число N "); ;
System.Console.WriteLine("Ряд целых натуральных чисел, расположенных между M и N : ");
PrintEvenNumber(numberStart, numberFinish);