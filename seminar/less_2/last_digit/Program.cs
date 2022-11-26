// 1. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message) // функция ввода числа с консоли
{
System.Console.Write($"{message} >");
int answer = Convert.ToInt32(Console.ReadLine());
return answer;
}
bool ValidateNumber(int number) // функция проверки на трехзначное число.
{
if (number >= 100 && number < 1000)
   {
      return true;
   }
   System.Console.WriteLine("Число не трехзначное");
   return false;
}
int number = Prompt("Введите число");  // вызов функции
if (ValidateNumber(number))
{
int result = number % 10;
System.Console.WriteLine($"Последняя цифра введенного числа {result}");
}