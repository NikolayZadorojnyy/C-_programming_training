// Собрать строку с числами от a до b, a ≤ b

// через цикл
string NumbersFor(int a, int b)
{
 string result = String.Empty;
 for (int i = a; i <= b; i++)
 {
 result += $"{i} ";
 }
 return result;
}
// через рекурсию
string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// Сумма чисел от 1 до n

// через цикл
int SumFor(int n)
{
 int result = 0;
 for (int i = 1; i <= n; i++) result += i;
 return result;
}
int SumRec(int n)
// через рекурсию
{
 if (n == 0) return 0;
 else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

// Факториал числа

// через цикл
int FactorialFor(int n)
{
 int result = 1;
 for (int i = 1; i <= n; i++) result *= i;
 return result;
}
// через рекурсию
int FactorialRec(int n)
{
 if (n == 1) return 1;
 else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

// Вычислить аn

// через цикл
int PowerFor(int a, int n)
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}
// через рекурсию
int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // можно записать через тернарный оператор
 if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a;
}
// через рекурсию
// 2 в степени 28 = 2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2 - 28 операция й
// если упростить выражение то получим 6 операций
int PowerRecMath(int a, int n)
{
 if (n == 0) return 1;
 else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
 else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024