// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] myArr = new int[a, b];
    Random myRnd = new Random();
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            myArr[i, j] = myRnd.Next(10);
            Console.Write($"{myArr[i, j]} ");
            if (i % 2 == 0 && j % 2 == 0) myArr[i, j] *= myArr[i, j];
        }
        Console.WriteLine();
    }
    return myArr;
}


void PrintArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
        // Console.WriteLine(string.Join(" ", arr[i,]));
    }
}

PrintArray(GetArray(n, m));