// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// Примеры:
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите цифры через пробел: ");
string s = Console.ReadLine();
string[] str_arr = s.Split(' ').ToArray();
int[] int_arr = new int[str_arr.Length];

int[] myStrToInt(string[] s_arr, int[] i_arr)
{
    int counter = 0;
    while (counter < s_arr.Length)
    {
        i_arr[counter] = int.Parse(s_arr[counter]);
        counter++;
    }
    return i_arr;
}

myStrToInt(str_arr, int_arr);
Console.WriteLine($"Вторая цифра: {int_arr[1]}");