// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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
        // Console.WriteLine(string.Join(" ", arr[i,]));
    }
}

int GetIntVariable(string message)
{
    Console.Write(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

void ChangeStringsInArray(int[,] arr, int firstStrPos, int secondStrPos)
{
    int tmp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        tmp = arr[firstStrPos , i];
        arr[firstStrPos , i] = arr[secondStrPos , i];
        arr[secondStrPos , i] = tmp;
    }
}

int n = GetIntVariable("Введите количество строк: ");
int m = GetIntVariable("Введите количество столбцов: ");
int[,] bestArr = GetArray(n, m);
PrintArray(bestArr);

Console.WriteLine();

ChangeStringsInArray(arr: bestArr, 
                        firstStrPos: GetIntVariable("Введите индекс первой строки: "),
                        secondStrPos: GetIntVariable("Введите индекс второй строки: "));
PrintArray(bestArr);