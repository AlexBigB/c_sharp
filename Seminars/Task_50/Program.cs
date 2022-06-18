// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

int[,] GetArray(int a, int b)
{
    int[,] myArr = new int[a, b];
    Random myRnd = new Random();
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            myArr[i, j] = myRnd.Next(10);
        }
    }
    return myArr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetItem(int[,] array, int[] position)
{
    if (position[0] >= array.GetLength(0) || position[1] >= array.GetLength(1))
        Console.WriteLine("Позиция элемента находится за границей массива!");
    else Console.WriteLine($"{array[position[0], position[1]]}");
}



Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] bestArr = GetArray(n, m);
PrintArray(bestArr);

Console.Write("Введите через запятую позиции элемента в двумерном массиве: ");
int[] pos = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
GetItem(bestArr, pos);


