﻿
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



/*
Console.Write("Введите номер дня недели (1-7): ");
int d1 = int.Parse(Console.ReadLine());
if ((d1 > 0) & (d1 < 7))
{
    if (d1 == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (d1 == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (d1 == 3)
    {
        Console.WriteLine("Среда");
    }
    if (d1 == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (d1 == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (d1 == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (d1 == 7)
    {
        Console.WriteLine("Воскресение");
    }

}    
else
{
    Console.WriteLine("Такого дня не бывает!");
}    

*/