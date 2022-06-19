// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

int GetIntVariable(string message)
{
    Console.Write(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

void SortArrayRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        bool rowSorted = false;
        while (rowSorted == false)
        {
            int changeCounter = 0;
            for (int j = 1; j < arr.GetLength(1); j++)
            {
                if (arr[i, j - 1] < arr[i, j])
                {
                    int tmpMax = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = tmpMax;
                    changeCounter++;
                }
            }
            if (changeCounter == 0) rowSorted = true;
        }

    }
}




int n = GetIntVariable("Введите количество строк: ");
int m = GetIntVariable("Введите количество столбцов: ");
int[,] bestArr = GetArray(n, m);
PrintArray(bestArr);

Console.WriteLine();

SortArrayRows(bestArr);
PrintArray(bestArr);
