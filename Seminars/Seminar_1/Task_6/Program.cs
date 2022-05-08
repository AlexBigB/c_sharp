/*
Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
Примеры:
4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine());
bool res = a%2==0;
Console.WriteLine(res ? "It's an even number" : " It's not an even number");