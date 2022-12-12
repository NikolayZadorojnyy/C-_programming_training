// **Задача 2:** Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.Write($"{message} ");              // Вывод приглашения
    return Convert.ToDouble(Console.ReadLine()); // ввод числа
}
double k1 = Prompt("Введите k1");
double b1 = Prompt("Введите b1");
double k2 = Prompt("Введите k2");
double b2 = Prompt("Введите b2");

// функция нахождения точки пересечения двух прямых
(double?, double?) LineIntersection(double k1, double b1, double k2, double b2) // выводим кортеж
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    x = Math.Round(x, 3); // метод вывода с тремя знаками после запятой
    y = Math.Round(y, 3);
    return (x, y); // возвращаем два значения при помощи кортежа
}
(double? X, double? Y) = LineIntersection(k1, b1, k2, b2); // кортеж
Console.WriteLine($"Пересечение в точке (x,y): ({X};{Y})");
