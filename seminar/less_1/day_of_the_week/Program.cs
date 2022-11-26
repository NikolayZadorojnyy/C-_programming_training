// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Write("Введите день недели > "); // Вывод приглашения ввода
string inputValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int value = Convert.ToInt32(inputValue); // Преобразование строки в число
switch (value)
{
case 1: System.Console.WriteLine("Понедельник");break;
case 2: System.Console.WriteLine("Вторник");break;
case 3: System.Console.WriteLine("Среда");break;
case 4: System.Console.WriteLine("Четверг");break;
case 5: System.Console.WriteLine("Пятница");break;
case 6: System.Console.WriteLine("Суббота");break;
case 7: System.Console.WriteLine("Воскресенье");break;
default: System.Console.WriteLine("Промах");break;
}