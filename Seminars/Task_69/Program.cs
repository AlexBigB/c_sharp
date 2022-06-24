// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Clear();
Console.Write("задайте число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("задайте число B: ");
int b = int.Parse(Console.ReadLine());

int tmp = a;
void Stepen(int result, int step, int foundation)
{
    if (step > 1)
    {
        Stepen(result *= foundation, step - 1, foundation);
    }
    if (step == 1) Console.WriteLine(result);
}
// Stepen(a, b, tmp);

int Pow(int num, int pow)
{
    return pow == 0 ? 1 : Pow(num, pow - 1) + num;
}
Console.WriteLine($"{Pow(a, b)}");