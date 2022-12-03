//Напишите программу, которая принимает на вход число и выдаёт 
//количество цифр в числе

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

//функция выдеет колиство цифр в числе
int CounterDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}
int number = Prompt("Введите число ");
Console.WriteLine($"Количество цифр в числе {number} = {CounterDigits(number)}");