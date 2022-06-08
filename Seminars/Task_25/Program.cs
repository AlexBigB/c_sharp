// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать метод возведения числа в степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int Exponentiate(int num1, int num2)
{
    int result = num1;
    for (int i = 0; i < b-1; i++) result *= num1;
    return result;
}

Console.WriteLine($"Число {a} в степени {b} равно {Exponentiate(a, b)}");