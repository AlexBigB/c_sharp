// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц

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

bool CheckMatrixes(int firstArrColumns, int secondArrRows) // A = [4,2]; B = [2,3]; C = A * B = C[4,3]
{
    if (firstArrColumns != secondArrRows) return false;
    else return true;
}

int[,] MultMatrixes(int[,] firstArr, int[,] secondArr)
{
    int[,] resMatrix = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(0); j++)
        {
            for (int n = 0; n < firstArr.GetLength(1); n++)
            {
                resMatrix[i,j] += firstArr[i,n] * secondArr[n, j];
            }
        }
    }
    return resMatrix;
}

int n = GetIntVariable("Введите количество строк 1 матрицы: ");
int m = GetIntVariable("Введите количество столбцов 1 матрицы: ");
int[,] firstMatrix = GetArray(n, m);
n = GetIntVariable("Введите количество строк 2 матрицы: ");
m = GetIntVariable("Введите количество столбцов 2 матрицы: ");
int[,] secondMatrix = GetArray(n, m);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
bool check = CheckMatrixes(firstMatrix.GetLength(1), secondMatrix.GetLength(0));
if (check)
{
    int[,] multResult = MultMatrixes(firstMatrix, secondMatrix);
    Console.WriteLine();
    PrintArray(multResult);
}
else Console.WriteLine("Данные матрицы нельзя перемножить!");