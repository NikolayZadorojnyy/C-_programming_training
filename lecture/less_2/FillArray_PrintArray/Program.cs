// готовый метод (функция) который заполняет массив 
// случайными числами от 1 до 10
void FillArray(int[] collection) 
{
   int length = collection.Length;
   int index = 0;
   while (index < length)
   {
   collection[index] = new Random().Next(1, 10);
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

int[] array = new int[10];   //определяем новый массив 
// вызываем оба этих метода
FillArray(array);
PrintArray(array);