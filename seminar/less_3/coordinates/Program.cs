// Напишите программу которая принимает на вход координаты точки (X и Y), причем икс не равен нулю или
// игрек не равен нулюи выдает номер четверти плоскости, в которой находится эта точка.

// Функция вывода приглашения и ввода целого числа 
int Prompt(string message)
{
    System.Console.Write($"{message} > "); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); //Ввод числа
}

// Проверка на корректность данных (икс или игрек не должны быть равны нулю.)
bool ValidateQuarter(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат равна 0 ");
        return false;
    }
    return true;
}

// Функция определения четверти по координатам
int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}
int coordX = Prompt("Ввелите х ");
int coordY = Prompt("Ввелите Y ");
if (ValidateQuarter(coordX, coordY))
{
int quarter = GetQuarter(coordX,coordY);
System.Console.WriteLine($"Полученная четверть {quarter}");
}