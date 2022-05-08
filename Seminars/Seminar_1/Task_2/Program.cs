/*
Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
Примеры:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Clear();
Console.Write("First number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
int b = int.Parse(Console.ReadLine());

if (a < b) Console.WriteLine(b);
else Console.WriteLine(a);
