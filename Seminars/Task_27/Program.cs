// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int NumberLenght(int n)
{
    int counter = 1;
    while (n > 9)
    {
        n /= 10;
        counter++;
    }
    return counter;
}

int[] NumberToArray(int n, int len)
{
    int[] result = new int[len];
    for (int i = len - 1; i > 0; i--)
    {
        result[i] = n % 10;
        n /= 10;
    }
    result[0] = n;
    return result;
}

void PrintArr(int[] myArr) //Данный метод был нужен в процессе отладки кода
{
    for (int i = 0; i < myArr.Length - 1; i++) Console.Write(myArr[i]);
    Console.WriteLine(myArr[myArr.Length - 1]);
}

int SumNumInArray(int[] myArr)
{
    int result = 0;
    for (int i = 0; i < myArr.Length; i++) result += myArr[i];
    return result;
}

Console.WriteLine($"Cумма цифр в числе = {SumNumInArray(NumberToArray(num, NumberLenght(num)))}");