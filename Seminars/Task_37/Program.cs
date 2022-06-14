// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Clear();
bool run = true;
while (run)
{
    int len = 7;
    int[] myArr = new int[len];

    void MyMethod(int[] a1, int[] a2)
    {
        var myRnd = new Random();
        for (int i = 0; i < (a1.Length / 2); i++)
        {
            a1[i] = myRnd.Next(0, 10);
            int j = a1.Length - 1 - i;
            a1[j] = myRnd.Next(1, 10);
            // Console.WriteLine($"i = {i}, j = {j}, a1[i] = {a1[i]}, a1[j] = {a1[j]}");
            a2[i] = a1[i] * a1[j];
            // Console.WriteLine(string.Join(", ", a1));
            // Console.WriteLine(string.Join(", ", a2));
        }

    }

    if (myArr.Length % 2 != 0)
    {
        int[] resArr = new int[(myArr.Length / 2) + 1];
        MyMethod(myArr, resArr);
        myArr[myArr.Length / 2] = new Random().Next(0, 10);
        resArr[resArr.Length - 1] = myArr[myArr.Length / 2];
        Console.WriteLine($"myArr = {string.Join(", ", myArr)}");
        Console.WriteLine($"resArr = {string.Join(", ", resArr)}");
    }
    else
    {
        int[] resArr = new int[myArr.Length / 2];
        MyMethod(myArr, resArr);
        Console.WriteLine($"myArr = {string.Join(", ", myArr)}");
        Console.WriteLine($"resArr = {string.Join(", ", resArr)}");
    }

    Console.WriteLine("Do you want to repeat? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
    Console.WriteLine();
}
