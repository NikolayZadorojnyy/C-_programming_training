// 3. Напишите программу вычисления функции:
// x = f(a) функиця куба
Console.WriteLine("Введите число > ");
string inputValue = Console.ReadLine();
int value = Convert.ToInt32(inputValue);
int cube = value * value * value;
System.Console.WriteLine("куб числа " + value + " равен " + cube);