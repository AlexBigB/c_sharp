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
        // Console.WriteLine($"res = {res}, ost = {ost}, cel = {cel}");
        dvoich(cel, res);
    }
    else
    {
        res += ost.ToString() + cel.ToString();
        // Console.WriteLine($"res = {res}, ost = {ost}, cel = {cel}");
        // char[] array = res.ToCharArray();
        // Array.Reverse(array);
        // res = array.ToString();
        string newRes = new string(res.ToCharArray().Reverse().ToArray());
        Console.WriteLine($"{newRes}");
        //return res;
    }
    // Console.WriteLine(res);
}
string r = string.Empty;
// Console.WriteLine($"{dvoich(n, r)}");
dvoich(n, r);
//Console.WriteLine($"{r}");

// void test(int a)
// {
//     // int cel = a / 2;
//     a /= 2;
//     if (a >= 2)
//     {
//         Console.WriteLine($"a = {a}, a /= 2 = {a / 2}");
//         test(a);
//         // Console.WriteLine(a);
//     }
// }
// test(n);

