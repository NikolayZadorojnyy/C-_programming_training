// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. . Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
int Promt(string message)
{
System.Console.Write($"{message}> ");
int input = Convert.ToInt32(Console.ReadLine());
return input;
}
int ThirdDigit(int number) // метод выводит третью цифру или -1(если число меньше трех)
{
int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result; 
}
int number = Promt("Введите число");  // вызов функции ввода
ThirdDigit(number);  //вызов функции нахождения третьей по счету цифры
int thirdDigit = ThirdDigit(number);
if(thirdDigit == -1) 
    {
         System.Console.WriteLine("В числе " + number + " нет третьей цифры");
    }
    else
    {
         System.Console.WriteLine("Третья цифра введенного числа " + number + " это " + thirdDigit +"");  
    }