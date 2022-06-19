// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();

int[,] GetArray(int numStrings, int numColumns)
{
    int[,] myArr = new int[numStrings, numColumns];
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

int[] FindMinElementPosition(int[,] arr)
{

    int min = arr[0, 0];
    int[] minPos = { 0, 0 };
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                minPos[0] = i;
                minPos[1] = j;
            }
        }
    }
    Console.WriteLine(string.Join(' ', minPos));
    return minPos;
}

int[,] DeleteColumnAndStringFromArray(int[,] arr, int[] positions)
{
    int[,] resArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int triggerI = 0;
    int triggerJ = 0;
    for (int i = 0; i < resArr.GetLength(0); i++)
    {
        if (i >= positions[0]) triggerI = 1;
        else triggerI =0;
        for (int j = 0; j < resArr.GetLength(1); j++)
        {
            if (j >= positions[1]) triggerJ = 1;
            else triggerJ = 0;
            resArr[i, j] = arr[i + triggerI, j + triggerJ];
        }
    }
    return resArr;
}

int GetIntVariable(string message)
{
    Console.Write(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int n = GetIntVariable("Введите количество строк: ");
int m = GetIntVariable("Введите количество столбцов: ");
int[,] bestArr = GetArray(n, m);
PrintArray(bestArr);

Console.WriteLine();

int[] pos = FindMinElementPosition(bestArr);
int[,] shortArr = DeleteColumnAndStringFromArray(bestArr, pos);
PrintArray(shortArr);