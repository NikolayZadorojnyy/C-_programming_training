// Имеется одномерный массив array из n элементов, 
// требуется найти индекс массива, элемент которого задал 
// пользователь (переменная find). Для зтого напишем функцию

// готовый метод (функция) который заполняет массив 
// случайными числами от 1 до 10
void FillArray(int[] collection) 
{
   int length = collection.Length;
   int index = 0;
   while (index < length)
   {
   collection[index] = new Random().Next(1, 10); //генератор сл чисел от 1 до 10
   //index = index + 1;
   index++;
   }
}

// готовый метод (функция) вывода массива на печать
void PrintArray(int[] col)
{
   int count = col.Length;
   int position = 0;
   while (position < count)
   {
   Console.WriteLine(col[position]);
   position++;
   }
}
// функция поиска индекса, соответсвующему элементу заданному пользователем
int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //-1 для того, чтобы в отсутствие элемента вывести минусовую
                       // позицию(что значит элемента нет), иначе выдаст 0
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //если много одинаковых элементов то остановимся на первом найденом
        }
        index++;
    }
    return position;
}
int[] array = new int[10];   //определяем новый массив 
// вызываем оба этих метода
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array,4);  //передаем в функцию аргументы(сам массив и 
                              // и элемент,заданный пользователем)
Console.WriteLine(pos);