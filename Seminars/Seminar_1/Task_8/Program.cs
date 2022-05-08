/*
Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
Примеры:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine());
int tmp = 2;
if (a > 1)
{
    while (tmp <= a)
    {
        Console.Write(tmp);
        if ((a%2==0) & (tmp < a)) Console.Write(", "); // чтобы не было запятой после последнего числа, если а четное
        else if (tmp < a-1)Console.Write(", "); // чтобы не было запятой после последнего числа, если а не четное
        tmp += 2;
    }
}
else Console.WriteLine("Pls enter another number");
