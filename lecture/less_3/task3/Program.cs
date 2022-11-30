// задача
// Был массив Было: 6 8 3 2 1 4 5 7
// Нужно сделать Результат: 1 2 3 4 5 6 7 8 

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
void selectionSort(int[] array) // метод сортировки массива от мин до макс
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
        if (array[j] < array[minPosition]) minPosition = j;
            
        }
        int temporary = array[i]; //временная переменная используемая для перезаписи элементов
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr); //вызов метода печати начального массива
selectionSort(arr); // вызов метода сортировки массива
PrintArray(arr); //печатаем конечный результат

