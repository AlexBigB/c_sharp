Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Num = {num}");
void delSecondDigit(int someNum)
{
    int firstDigit = someNum / 100;
    int secondDigit = someNum / 10 % 10;
    int thirdDigit = someNum % 10;
    Console.WriteLine($"Result = {firstDigit * 10 + thirdDigit}");
}

delSecondDigit(num);