﻿// Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7
Console.Write("Введите число N > "); // Вывод приглашения ввода
string inputValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int N = Convert.ToInt32(inputValue); // Преобразование строки в число
if (N < 0)
{
N=-N;
}
Console.Write("Модуль числа N = " + N);