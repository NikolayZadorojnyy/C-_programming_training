/// 3.1. Напишите программу, которая будет принимать на вход пять 
// чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
System.Console.Write($"{message}> ");
int answer = Convert.ToInt32(Console.ReadLine());
return answer;
}
int len = Prompt ("Введите количество чисел:");
int index = 0;
double sum = 0;
while (index < len)
   {
     int value = Prompt ($"Введите {index} число");
     sum = sum + value;
     index++;
   }
double avg = sum/index;
Console.WriteLine($"Сумма = {sum}");
Console.WriteLine($"Среднее = {avg:f2}"); // f2 это просто формат вывода два числа после запятой
