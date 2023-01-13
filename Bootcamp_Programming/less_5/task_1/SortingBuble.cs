public static class SortingBuble
{
  /// <summary>Сортировка пузырьком</summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив массив</returns>
public static int[] SortBuble(this int[] collection)
  {
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
      for (int j = 0; j < size - 1; j++)
      {
        if (collection[j] > collection[j + 1])
        {
          int temp = collection[j];
          collection[j] = collection[j + 1];
          collection[j + 1] = temp;
        }
      }    
      Console.WriteLine("[" + string.Join(", ", collection) + "] шаг "+ (i+1));
    }
    return (collection);
  }
}