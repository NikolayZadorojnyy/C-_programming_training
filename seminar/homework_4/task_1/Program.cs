// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Реализовать через функции.

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// функция А в степени В
int funkAdegreeB(int value1, int value2)
{
    int result = 1;
    for (int i = 1; i <= value2; i++)
    result *= value1;
    return result; 
}
int A = Promt("Введите число A: ");
int B = Promt("Введите число B: ");

Console.WriteLine($"Число {A} в степени {B} = {funkAdegreeB(A,B)}");
