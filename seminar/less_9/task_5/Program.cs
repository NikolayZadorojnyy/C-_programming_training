// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”
bool PowerTwo (int number)
{
    if (number==2)
    {
        return true;
    }
    return (number%2==0)&&PowerTwo(number/2);
}
System.Console.WriteLine(PowerTwo(45));
System.Console.WriteLine(PowerTwo(12));
System.Console.WriteLine(PowerTwo(64));