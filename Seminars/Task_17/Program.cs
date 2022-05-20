Console.Clear();
Console.Write("enter x pls: ");
int x = int.Parse(Console.ReadLine());
Console.Write("enter x pls: ");
int y = int.Parse(Console.ReadLine());

// bool b_x = x != 0;
// bool b_y = y != 0;
// if (b_x || b_y)

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}


