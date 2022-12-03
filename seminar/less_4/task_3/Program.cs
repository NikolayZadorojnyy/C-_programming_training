// Напишите программу, которая принимает на
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int value = Promt("Введите число: ");
// функция нахождения факториала числа value
int Factirial(int value)
{
    int value1 = 1;
    for (int i = 1; i <= value; i++)
    {
        value1 = value1 * i;
    }
    return value1;
}
Console.WriteLine($"Произведение чисел от 1 до {value} будет равно {Factirial(value)}");