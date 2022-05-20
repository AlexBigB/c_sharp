Console.Clear();
Console.Write("N: ");
int n = int.Parse(Console.ReadLine());

void PowBorder(int num)
{
    int counter = 2;
    while (counter < num+1 && num > 1)
    {
        Console.WriteLine($"{counter} | {Math.Pow(counter, 2)}");
        counter++;
    }
}

PowBorder(n);