// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
void MyMult(int n)
{
    int res = 1;
    for(int i = 1; i <= n; i++) res *= i;
    Console.WriteLine($"{n} -> {res}");
}
MyMult(number);