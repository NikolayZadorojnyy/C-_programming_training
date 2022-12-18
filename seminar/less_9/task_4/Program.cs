// Задача 4: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
int Power(int number,int power)
{
    if(power==0)
    {
        return 1;
    }
    return number*Power(number,power-1);
}
System.Console.WriteLine(Power(3,4));
