// Задача 65: Задайте значения num и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от num до N.
// num = 1; N = 5 -> "1, 2, 3, 4, 5"
// num = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
Console.Write("задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("задайте число n: ");
int n = int.Parse(Console.ReadLine());

// if (n < m) NeturalNUmber(m, n);
// else NeturalNUmber(n, m);
NeturalNUmber(m, n);
void NeturalNUmber(int mum, int num)
{
    if (mum < num)
    {
        if (mum - 1 == num) return;
        NeturalNUmber(mum, num - 1);
        Console.Write($"{num} ");
    }
    if (mum > num)
    {
        if (mum + 1 == num) return;
        NeturalNUmber(mum, num + 1);
        Console.Write($"{num} ");
    }
    if (mum == num)
    {
        Console.Write($"{mum} ");
    }
}
