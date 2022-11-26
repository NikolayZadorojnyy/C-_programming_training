// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int Promt(string message)
{
System.Console.Write($"{message}");
int input = Convert.ToInt32(Console.ReadLine());
return input;
}
int input1 = Promt("add numer ");
int delitel1 = Promt("add delitel 1: ");
int delitel2 = Promt("add delitel 2: ");
if (input1%delitel1 == 0 && input1%delitel2 == 0)//если && то достаточно проверить первое условие и если
                                                 // false то второе не проверяется, а если & то проверяются оба условия
{
Console.WriteLine("Число кратно двум введённым числам");
} 
else
{
Console.WriteLine("Число не кратно двум введённым числам");
}
