
Console.Write("Введите число А: ");
double a = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
double b = int.Parse(Console.ReadLine());

double aa = a/b;
bool res = b * b == a;
Console.WriteLine(res ? "Yes" : "No"); //тернарный оператор 

//Console.Write(aa);
/*
if (aa == b)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
*/
