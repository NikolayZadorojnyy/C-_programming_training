// Задача 2: Напишите программу, которая будет преобразовывать десятичное
// число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string message)
{
    Console.Write($"{message} ");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine(list[i]);
    }
}

// функция перевода десятичного числа в двоичное
int[] ToBinary(int Arg1)
{
    int[] number = new int[8];
    int count = 1;
    while (Arg1 > 0)
    {
        int Ostatok = Arg1 % 2;
        number[number.Length - count] = Ostatok;
        count++;
        Arg1 = Arg1 / 2;
    }
    return number;

}


int A = Prompt("Введите число:> ");
PrintList(ToBinary(A));

