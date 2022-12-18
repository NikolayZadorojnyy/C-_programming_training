// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”
bool SimpleNumber(int number,int divider)
{
    if(divider==1)
    {
        return true;
    }
    if(number%divider!=0)
    {
        return SimpleNumber(number,divider-1);
    }
    else
    {
        return false;
    }
}
bool SimpleNumber1(int number)
{
    return SimpleNumber(number,number-1);
}
System.Console.WriteLine(SimpleNumber1(11));
System.Console.WriteLine(SimpleNumber1(45));
System.Console.WriteLine(SimpleNumber1(79));
