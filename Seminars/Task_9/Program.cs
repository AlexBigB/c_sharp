Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine($"firstDigit = {firstDigit}");
Console.WriteLine($"secondDigit = {secondDigit}");
Console.WriteLine(firstDigit >= secondDigit ? $"max = {firstDigit}" : $"max = {secondDigit}"); //интерполяция
//Console.WriteLine(firstDigit >= secondDigit ? "max = " + firstDigit : "max = " + secondDigit); //канкатенация

int MaxNumber(int someNum)
{
    int a = someNum / 10;
    int b = someNum % 10;
    return a > b ? a : b;
}

Console.WriteLine($"Max = {MaxNumber(number)}");

void PrintMaxNumber(int someNum)
{
    int a = someNum / 10;
    int b = someNum % 10;
    Console.WriteLine(a > b ? $"MAX = {a}" : $"MAX = {b}");
}

PrintMaxNumber(number);
