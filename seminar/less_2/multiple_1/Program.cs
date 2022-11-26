// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если число
// 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

int Promt(string message)
{
System.Console.Write($"{message}");
int input = Convert.ToInt32(Console.ReadLine());
return input;
}
int input1 = Promt("add Firsr numer ");
int input2 = Promt("add Second nubmer ");
int div = input1 % input2;
if (div > 0)
{
Console.WriteLine("Числа не кратыне, остаток от деления равен: " + div);
}
else
{
Console.WriteLine("Чсила кратные");
}
