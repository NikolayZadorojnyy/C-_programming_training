// Написать программу на языке C#, для Windows и Mac OS, 
// [в которую пользователь вводит два целых числа] 
// [в которой записаны два целых числа] 
// [два целых числа генерируются случайным образом] и получает сумму
//int numberA = new Random().Next(1,10);
//int numberB = new Random().Next(1,10);
//int result = numberA + numberB;
//Console.WriteLine(result);
int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = (numberA + numberB);
Console.WriteLine(result);