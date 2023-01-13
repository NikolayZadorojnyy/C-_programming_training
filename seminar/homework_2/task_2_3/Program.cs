// Напишите программу, которая выводит случайное трёхзначное число и
//  удаляет вторую цифру этого числа. Не использовать строки для расчета
// 456 -> 46782 -> 72918 -> 98

int value = new Random().Next(100, 1000);             //генерируем число от 100 до 999
Console.WriteLine($"Исходное число = {value}");
var str = value.ToString();                           //Превращаем число в строку
int number = int.Parse(str.Remove(str.Length - 2, 1)); //удаляем 1 символ со второй позиции с конца в строке
Console.WriteLine($"Число после удаления второй цифры = {number}");

// еще вариант

int num = new Random().Next(100, 1000);             //генерируем число от 100 до 999
Console.WriteLine(num);
num = (num % 10) + (num / (10 * 10)) * 10; // так как переменная int - то дробная часть выкинется
Console.WriteLine(num);

// Напишите программу, которая выводит случайное трёхзначное число и
//  показывает вторую цифру этого числа.

int num1 = new Random().Next(100, 1000);             //генерируем число от 100 до 999
Console.WriteLine(num1);
num1 %= 100; //num1 = num1%100 ;
num1 /= 10;  // num1 = num1 / 10;
Console.WriteLine(num1);

// Напишите программу, которая выводит случайное  число и
//  показывает третью цифру этого числа или сообщает что ее нет.

int num2 = new Random().Next();             //генерируем любое число
Console.WriteLine($"Исходное число {num2}");
Value3(num2);
do
int Value3(int num3) //функция определения третьей цифры числа
{
  if (num3 < 100 && num3 > -100) return -1;
  else
  {
    while (!(num3 / 1000 == 0))
    {
      num3 /= 10;
    }
    num3 %= 10;
  }
  return (num3 >= 0 ? num3 : -num3);
}
if (Value3(num2) == -1)
{
  System.Console.WriteLine("У этого числа нет третьей цифры ");
}
else
  System.Console.WriteLine($"Третья цифра числа {num2} это {Value3(num2)}");