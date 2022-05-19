Console.Clear();
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

void multiple(int n1, int n2)
{
    Console.WriteLine(n1 % n2 == 0 ? "Multiple" : $"Not multiple {n1 % n2}");
}
multiple(num1, num2);