// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 275 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
System.Console.Write($"{message}> "); // вывод приглашения
int answer = Convert.ToInt32(Console.ReadLine()); // ввод числа
return answer;
}

int number = Prompt("Введите число ");
int start = 1;

int mod = number;
if (mod <0)
{
mod = -mod;
}

while (start <= mod)
{
int cube = start*start*start;
System.Console.WriteLine($"Число {start} в кубе равно {cube}");
start += 1;
}