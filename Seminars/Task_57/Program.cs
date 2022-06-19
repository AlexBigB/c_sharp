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

int[] CountValues(int[,] arr)
{
    int[] counter = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int tmp = arr[i, j];
            counter[tmp]++;
        }
    }
    return counter;
}

void PrintDictionary(int[] counter)
{
    for (int i = 0; i < counter.Length; i++)
    {
        Console.WriteLine($"{i} встречается следующее количество раз: {counter[i]}");
    }
}

int n = GetIntVariable("Введите количество строк: ");
int m = GetIntVariable("Введите количество столбцов: ");
int[,] bestArr = GetArray(n, m);
PrintArray(bestArr);
Console.WriteLine();
int[] count = CountValues(bestArr);
PrintDictionary(count);