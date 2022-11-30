// задача
// Был массив Было: 6 8 3 2 1 4 5 7
// Нужно сделать Результат: 8 7 6 5 4 3 2 1 

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)        //метод вывода массива на консоль
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectSortMaxMin(int[] array) // метод сортировки массива от мин до макс
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
        if (array[j] > array[maxPosition]) maxPosition = j;
            
        }
        int temporary = array[i]; //временная переменная используемая для перезаписи элементов
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr); //вызов метода печати начального массива
selectSortMaxMin(arr); // вызов метода сортировки массива
PrintArray(arr); //печатаем конечный результат