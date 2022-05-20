// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которую вы хотите возводить числа: ");
int p = int.Parse(Console.ReadLine());
void PowBorder(int num, int po)
{
    int counter = 1;
    while (counter < num+1)
    {
        Console.WriteLine($"{counter} | {Math.Pow(counter, po)}");
        counter++;
    }
}

PowBorder(n, p);