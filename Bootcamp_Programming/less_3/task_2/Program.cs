// алгоритм таблица умножения стандартным способом
// сложность выполнения O(n^2)
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
  for (int j = 1; j <= n; j++)
  {
    System.Console.Write(i * j);
    System.Console.Write("\t");
  }
  System.Console.WriteLine();
}

// алгоритм таблица умножения выполняется в два раза быстрее  
// за счет заполнения только половины матрицы буквой г
// сложность выполнения O(n^2/2)
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, m];
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < m; j++)
  {
    matrix[i, j] = (i + 1) * (j + 1);
    matrix[j, i] = (i + 1) * (j + 1);
  }
}
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < m; j++)
  {
    System.Console.Write(matrix[i, j]);
    System.Console.Write("\t");
  }
  System.Console.WriteLine();
}