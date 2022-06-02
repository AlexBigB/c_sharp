// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

void SymInNum (int n)
{
    if (n < 0) n *= -1;
    int counter = 0;
    for (int i = 1; i <= n; i *= 10) counter++;
    Console.WriteLine($"Цифр в числе: {counter}");
}

SymInNum(num);
