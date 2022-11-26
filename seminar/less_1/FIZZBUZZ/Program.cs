// Составить программу, которая выводит числа от 1 до 100, если число кратно 3, 
// то вместо числа пишет FIZZ, если число кратно 5, то пишем BUZZ, если число 
//кратно и 3 и 5, то пишем FIZZBUZZ
bool Is_FIZZ (int N)
{
if (N%3==0)
{
Console.Write("FIZZ");
return true;
}
return false;
}
bool Is_BUZZ (int N)
{
if (N%5==0)
{
Console.Write("BUZZ");
return true;
}
return false;
}
int N = 1;
while (N <= 100)
{
if (Is_FIZZ(N) | Is_BUZZ(N))
{
Console.WriteLine();
}
else Console.WriteLine(N);
N = N+1;
}