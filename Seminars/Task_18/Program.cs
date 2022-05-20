Console.Clear();
Console.Write("enter number: ");
int q = int.Parse(Console.ReadLine());

if (q == 1) Console.WriteLine("x > 0, y > 0");
else if (q == 2) Console.WriteLine("x < 0, y > 0");
else if (q == 3) Console.WriteLine("x < 0, y < 0");
else if (q == 4) Console.WriteLine("x > 0, y < 0");