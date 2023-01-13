// Сложность работы алгоритма - O(n) (5 операций)

int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
  array[i] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("[" + string.Join(" ", array) + "]");
int summa = 0;
for (int i = 0; i < n; i++)
  summa += array[i];  // сумма всех элементов массива
System.Console.WriteLine(summa);
