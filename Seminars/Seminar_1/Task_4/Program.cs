/*
Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
Примеры:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
Console.Write("First number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Third number: ");
int c = int.Parse(Console.ReadLine());
int max =a;
if (max < b) max = b;
if (max < c) max = c;
Console.Write("Max number: ");
Console.WriteLine(max);
