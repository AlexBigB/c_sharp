// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

void PrintOneDimArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
}

int[] CountValuesInRow(int[,] arr)
{
    int[] counter = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            counter[i] += arr[i, j];
        }
    }
    return counter;
}

int MinRowIndex(int[] counter)
{
    int minValue = counter[0];
    int minPosition = 0;
    for (int i = 1; i < counter.Length; i++)
    {
        if (minValue > counter[i])
        {
            minValue = counter[i];
            minPosition = i;
        }
    }
    return minPosition;
}

void PrintMinRowInArray(int[,] arr, int position)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[position, j]} ");
    }
    Console.WriteLine();

}

int n = GetIntVariable("Введите количество строк: ");
int m = GetIntVariable("Введите количество столбцов: ");
int[,] bestArr = GetArray(n, m);
PrintArray(bestArr);
Console.WriteLine();
int[] sums = CountValuesInRow(bestArr);
PrintOneDimArr(sums);
Console.WriteLine();
int index = MinRowIndex(sums);
PrintMinRowInArray(bestArr, index);