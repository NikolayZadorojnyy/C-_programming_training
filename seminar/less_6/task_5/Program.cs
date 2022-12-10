// Задача 1. Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.

int Prompt(string message)
{
    Console.Write($"{message} ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

bool CheckSize(int A, int B, int C)
{
    if ((A + B) > C)
    {
        return true;
    }
    return false;
}
int A = Prompt("Введите длину первой стороны ");
int B = Prompt("Введите длину второй стороны ");
int C = Prompt("Введите длину третьей стороны ");

if (CheckSize(A, B, C) && CheckSize(B, C, A) && CheckSize(A, C, B))
{
    System.Console.WriteLine("Да, такой треугольник может существовать");
}
else
{
    System.Console.WriteLine("Такого треугольника не существует");
}