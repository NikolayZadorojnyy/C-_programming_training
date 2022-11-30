//1. void метод который ничего не принимает и не возвращает
void Metod1()
{
    Console.WriteLine("1. Автор …");
}
Metod1(); // вызов метода

//2.void метод, который что то принимает, но ничего не возвращает.
void Metod2(string msg)
{
    Console.WriteLine(msg);  //оператор, в скобках указан принятый аргумент.
}
Metod2("2. Текст сообщения"); // где Metod2 является идентификатором, а в скобках
                              //указан текст, выводимый в консоли.

// 21.void метод который принимает на вход именованные аргументы, 
// но ничего не возвращает

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);  //где переменная count отображает на экране
                                 //определённое количество сообщений msg.
        i++;
    }
}
Metod21("21. Текст", 4); //-метод вызывает Текст, после запятой указано количество
                         //вызовов, в нашем случае 4.

// 22.Теперь идея в том, что мы можем в том числе явно указывать к какому 
// аргументу, какое значение мы хотим присвоить, через такую конструкцию.

void Metod22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);  //где переменная count отображает на экране
                                 //определённое количество сообщений msg.
        i++;
    }
}
Metod22(msg: "22. Новый текст", count: 4);

// 3.Эти методы, которые что-то возвращают, но ничего не принимают

int Metod3()  //не принимает никакие аргументы
{
    return DateTime.Now.Year;// обязательное использование оператора return,
}
int year = Metod3(); // вызываем метод, в левой части используем идентификатор
                     // переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine($"3. {Metod3()}");

//4. Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.

string Metod4(int count, string text) // Мы будем string компоновать друг за другом count раз
{
    int i = 0;
    string result = String.Empty; //пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "4. ");  //вызываем метод
Console.WriteLine(res);

//4. Предыдущая задача на цикле for.

string Metod41(int count, string text) // Мы будем string компоновать друг за другом count раз
{
    string result = String.Empty;   //пустая строка
    for (int I = 0; I < count; I++) // вначале ключевое слово, затем инициализация счётчика, 
                                    // после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res1 = Metod41(10, "4.for ");  //вызываем метод
Console.WriteLine(res1);

// цикл в цикле

for (int a = 2; a <= 10; a++)
{
    for (int b = 2; b <= 10; b++)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
    Console.WriteLine();
}