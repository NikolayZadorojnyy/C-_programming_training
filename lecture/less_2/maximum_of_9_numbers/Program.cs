// Поищем максимум из 9 чисел
// Простое линейное решение
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue1 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int a = Convert.ToInt32(inputValue1); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue2 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int b = Convert.ToInt32(inputValue2); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue3 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int c = Convert.ToInt32(inputValue3); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue4 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int d = Convert.ToInt32(inputValue4); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue5 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int e = Convert.ToInt32(inputValue5); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue6 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int f = Convert.ToInt32(inputValue6); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue7 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int g = Convert.ToInt32(inputValue7); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue8 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int i = Convert.ToInt32(inputValue8); // Преобразование строки в число
Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue9 = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int h = Convert.ToInt32(inputValue9); // Преобразование строки в число
int max = 0;
if(max < a)max = a;
if(max < b)max = b;
if(max < c)max = c;
if(max < d)max = d;
if(max < e)max = e;
if(max < f)max = f;
if(max < g)max = g;
if(max < i)max = i;
if(max < h)max = h;
Console.WriteLine(max);