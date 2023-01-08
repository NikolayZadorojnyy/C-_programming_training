// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int value = new Random().Next(10000, 100000); //генерируем пятизначное число
Console.WriteLine($"Исходное число = {value}"); // выводим исходное число

bool FindPalindrom(int number) //Функция нахождения палиндрома
{
    // помещаем исходное число в строковюю переменную
    var text = number.ToString();
    //создаём массив символов с типом char, чтобы по одному символу считать нашу строку.
    char[] obrtext = text.ToCharArray();
    //переворачиваем массив
    Array.Reverse(obrtext);
    string finaltext = new string(obrtext); // получили новую перевернутую строку
    if (text == finaltext)
    {
        System.Console.WriteLine("Данное число является палиндромом");
        return true;
    }
    System.Console.WriteLine("Данное число не является палиндромом");
    return false;
}

FindPalindrom(value);
