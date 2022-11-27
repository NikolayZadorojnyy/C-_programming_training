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
int value = new Random().Next(1, 8);             //генерируем число от 1 до 7
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