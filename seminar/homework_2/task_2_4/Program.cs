//Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным. Не использовать строки
// 6 -> да7 -> да1 -> нет
int DayOff(int number) // функция определяет день недели
{
    int result = -1;
    if (number > 5 && number < 8)
    {
        result = 1;
    }
    return result;
}
int value = new Random().Next(1, 8); //генерируем число от 1 до 7
Console.WriteLine($"Исходное число = {value}");
DayOff(value);
int condition = DayOff(value);
if (condition == 1)
{
    Console.WriteLine($"Веденное число {value} - это выходной день");
}
else
{
    Console.WriteLine($"Введенное число {value} - это рабочий день");
}

// еще решение через switch

System.Console.WriteLine("Ведите день недели ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 6:
    case 7:
        Console.WriteLine("День является выходным");
        break;
    default:
        System.Console.WriteLine("День не является выходным");
        break;
}

// еще решение чеоез else if

System.Console.WriteLine("Ведите день недели ");
int number = Convert.ToInt32(Console.ReadLine());
int day = number;
if (day >= 1 && day <= 5)
{
    System.Console.WriteLine("День является рабочим ");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("День является выходным ");
}
else
{
    System.Console.WriteLine("Некорректное число ");
}
