// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("задайте число n: ");
int n = int.Parse(Console.ReadLine());
int res = 0;
void ParseInt(int num, int temp)
{
    if (num > 9)
    {
        temp += num % 10;
        ParseInt(num / 10, temp);
    }
    else 
    {
        temp += num;
        Console.WriteLine(temp);
    }
}

ParseInt(n, res);