// Написать программу, которая из имеющегося массива строк формируем массив, длина 
// которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// функция ввода параметров
int Prompt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// функция генерации массива случайных строк из алфавита и цифр
string[] RandomRowsGenerateArr(int len, int minRange, int maxRange)
{
    string[] randomArray = new string[len];
    Random res = new Random();
    String str =
      "abcdefghijklmnopqrstuvwxyz"
    + "ABCDEFGHIGKLMNOPQRSTUVWXYZ"
    + "0123456789";

    for (int i = 0; i < randomArray.Length; i++)
    {
        String randomString = "";
        // здесь формируем строку в пределах заданных параметров
        for (int j = 0; j < new Random().Next(minRange, maxRange + 1); j++)
        {
            int x = res.Next(str.Length);
            randomString = randomString + str[x];
        }
        randomArray[i] = randomString;
    }
    return randomArray;
}
// функция вывода массива
void PrintArray(string[] array, int printOut)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (printOut == 1) // вывод в строку или столбец
            Console.WriteLine(array[j] + " ");
        else
            Console.Write(array[j] + " ");
    }
}

// функция поиска элементов массива меньше заданной длины
string[] ShortArray(string[] array1, int n)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= n)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    if (count == 0)  
        System.Console.WriteLine("Элементов отвечающих заданным критериям нет.");
    return array2;
}

int range = Prompt("Введите длину начального массива > ");
int minValue = Prompt("Введите мин. кол-во символов в переменной начального массива > ");
int maxValue = Prompt("Введите макс. кол-во символов в переменной начального массива > ");
int limitingValue = Prompt("Введите предельное кол-во символов в переменной конечного массива > ");

string[] arr = RandomRowsGenerateArr(range, minValue, maxValue);
System.Console.Write("Исходный массив: ");
PrintArray(arr, 0);    // печатаем исходный массив в строку
System.Console.WriteLine();
System.Console.Write("Измененный массив: ");
PrintArray(ShortArray(arr, limitingValue), 0); // печатаем измененный массив в строку
