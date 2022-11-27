// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int Prompt(string message)
{
Console.Write($"{message} > "); // Вывод приглашения
return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
int x1 = Prompt("Введите x1");
int x2 = Prompt("Введите x2");
int y1 = Prompt("Введите y1");
int y2 = Prompt("Введите y2");
int z1 = Prompt("Введите z1");
int z2 = Prompt("Введите z2");
int deltax = x1 - x2;
int deltay = y1 - y2;
int deltaz = z1 - z2;

//Math.Sqrt() – математическая функция которая извлекает квадратный корень. В аргументных 
//скобках указывается значение числа, из которого нужно извлечь квадратный корень.
double distance = Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
System.Console.WriteLine("Расстояние между точками {0}", distance );                      
                                                        
