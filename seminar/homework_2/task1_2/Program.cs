// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает **вторую** цифру этого числа. Не использовать строки
// 456 -> 5782 -> 8918 -> 1
int Prompt(string message) // функция ввода числа с консоли
{
System.Console.Write($"{message} > ");
int answer = Convert.ToInt32(Console.ReadLine());
return answer;
}
bool ValidateNumber(int number) // функция проверки на трехзначное число.
{
if ((number >= 100 && number < 1000) || (number > -1000 && number <= -100))
   {
      return true;
   }
   System.Console.WriteLine("Число не трехзначное");
   return false;
}
int number = Prompt("Введите число");  // вызов функции ввода
if (ValidateNumber(number)) // если число трехзначное = true
{
int result = number / 10 % 10;
   if (result < 0) // выодим вторую цифру без знака -
      {
          result = - result;
      }
System.Console.WriteLine($"Вторая цифра введенного числа {result}");
}
