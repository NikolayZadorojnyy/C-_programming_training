// 2. Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8 

int value1 = new Random().Next(10, 100);
Console.WriteLine(value1);
int edinica = value1 % 10;
int desyatki = value1 / 10;
if (edinica > desyatki)
{
Console.WriteLine("Наибольшая цифра числа " + edinica);
}
else
{
Console.WriteLine("Наибольшая цифра числа " + desyatki);
}
