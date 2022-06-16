// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.Write("Enter num: ");
int n = int.Parse(Console.ReadLine());
// string res = i.ToString();
// Console.WriteLine(res);
// int n = 7;
// res += i.ToString();
// Console.WriteLine(res);



void dvoich(int a, string res)
{
    int cel = a / 2;
    int ost = a % 2;
    if (cel >= 2)
    {
        res += ost.ToString();
        dvoich(cel, res);
    }
    else
    {
        res += ost.ToString() + cel.ToString();
        string newRes = new string(res.ToCharArray().Reverse().ToArray());
        Console.WriteLine($"{newRes}");
    }
}
string r = string.Empty;
dvoich(n, r);

void dvInt(int a, int res, int d)
{
    if (a != 0)
    {
        res = res + a % 2 * d;
        a /= 2;
        d *= 10;
        dvInt(a, res, d);
    }
    else Console.WriteLine(res);
}
int re = 0;
int d10 = 1;
dvInt(n, re, d10);