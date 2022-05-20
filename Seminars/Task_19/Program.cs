// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите число: ");
char[] char_arr = Console.ReadLine().ToArray();

bool MyCompare(char a, char b, bool r)
{
    r = a == b;
    return r;
}

if (char_arr.Length % 2 == 1)
{
    int counter = 0;
    bool res = true;
    while (counter < char_arr.Length / 2 && res)
    {
        res = MyCompare(char_arr[counter], char_arr[char_arr.Length - 1 - counter], res);
        counter++;
    }
    Console.WriteLine(res ? "Да" : "Нет");
}
else Console.WriteLine("В этом числе четное количество символов и оно не может быть полиндромом");
