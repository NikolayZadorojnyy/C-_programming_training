// Напишите программу, которая на вход принимает число и выдаёт его квадрат
//(число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Write("Введите число > "); // Вывод приглашения ввода
var inputValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int value = Convert.ToInt32(inputValue); // Преобразование строки в число
int squareValue = value * value; // вычисление квадрата
System.Console.WriteLine("Квадрат значения " + value + " равен " + squareValue);
System.Console.WriteLine($"Квадрат значения {value} равен {squareValue}");