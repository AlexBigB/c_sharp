// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


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
Console.WriteLine(int_arr.Length > 2 ? $"Третья цифра: {int_arr[2]}" : "Нет третьей цифры");