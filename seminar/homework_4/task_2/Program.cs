// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Реализовать через функции.

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int value = Promt("Введите число: ");

// функция подсчета суммы всех цифр числа
int SumOfDigits(int value)
{
int sum = 0;
        while(value > 0)
        {
            sum += value % 10;
            value /= 10;
        }
        return sum;
}
System.Console.WriteLine($"Сумма всех цифр равна = {SumOfDigits( value)}");