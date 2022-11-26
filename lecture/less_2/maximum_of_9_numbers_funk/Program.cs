// Поищем максимум из 9 чисел
// Простое линейное решение с применением функции нахождения максимума из трех
// и функции ввода данных с консоли

int Max(int arg1, int arg2, int arg3) //функция нахождения макс из трех аргументов
{
int result = arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result;
}

int GetData() // метод(функция) ввода данных
{
   Console.Write("Введите значение ");// Ввод строки с терминала (с консоли)
   return Convert.ToInt32(Console.ReadLine()); // Преобразование строки в число
};
int a1 = GetData();
int b1 = GetData();
int c1 = GetData();
int a2 = GetData();
int b2 = GetData();
int c2 = GetData();
int a3 = GetData();
int b3 = GetData();
int c3 = GetData();

//  int max1 = Max(a1, b1, c1);
//  int max2 = Max(a2, b2, c2);   // можно так сделать
//  int max3 = Max(a3, b3, c3);
//  int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1),
              Max(a2, b2, c2),    // более короткая запись
              Max(a3, b3, c3)
              );

Console.WriteLine(max);