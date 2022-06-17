// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите элементы масстива через запятую: ");
int[] myArr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

void CountPos(int[] arr)
{
    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) pos++;
    }
    Console.WriteLine($"Положительных чисел: {pos}");
}
CountPos(myArr);