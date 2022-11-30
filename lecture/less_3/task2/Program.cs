//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ " ежели бы вас послали вместо нашего милого Винценгероде,"
+ " вы бы взяли приступом согласие прусского короля."
+ " Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; //задаем пустую строку
    int length = text.Length; //свойство показывающее кол-во символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text,' ', '|'); //вызов метода с подстановкой значений
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(text, 'к', 'К');  //вызов метода с подстановкой значений
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(text, 'с', 'С');  //вызов метода с подстановкой значений
Console.WriteLine(newText);
Console.WriteLine();