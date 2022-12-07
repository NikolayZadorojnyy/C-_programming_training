// Вычисление факториала чеоез рекурсию

int Factorial(int n) // на 17 шаге имеем переполнение
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
System.Console.WriteLine();
double Factorial1(int n) // решили проблему переполнения
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial1(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial1(i)}");
}