// 3. Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Prompt(string message)
{
System.Console.Write($"{message} > ");
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
int input1 = Prompt ("Added first number");
int input2 = Prompt ("Added second number");
int div = input1 % input2;
if (div > 0)
{
Console.WriteLine("Число " + input1 + " не кратно числу " + input2);
}
else
{
Console.WriteLine("Число " + input1 + " КРАТНО числу " + input2);
}