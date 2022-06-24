// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();

void NaturalNumber(int num, int border)
{
    if (border == num + 1) return;
    NaturalNumber(num, border + 1);
    Console.Write($"{border} ");
}

Console.Write("Задайте число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("До какого числа выводить натуральные числа числа: ");
int b = int.Parse(Console.ReadLine());
NaturalNumber(n, b);
