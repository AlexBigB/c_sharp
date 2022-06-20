// Заполните спирально массив 4 на 4.
Console.Clear();

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

int TryStepForward(int[,] arr, int currentY, int currentX, int currentVal)
{
    if (arr[currentY, currentX + 1] < arr.GetLength(1) && arr[currentY, currentX + 1] == 0)
    {
        arr[currentY, currentX + 1] = currentVal;
        return ++currentVal;
    }
    else return currentVal;
}

int[,] TurnArray(int[,] arr)
{
    int[,] tmpArr = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < tmpArr.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArr.GetLength(1); j++)
        {
            tmpArr[i, j] = arr[j, tmpArr.GetLength(0) - 1 - i];
        }
    }
    return tmpArr;

}

int n = GetIntVariable("Введите количество строк: ");
int m = GetIntVariable("Введите количество столбцов: ");
int[,] newArr = new int[n, m];
newArr[0, 0] = 1;
int currentValue = 2;
int countTurning = 0;
int lapIndex = 0; //необходимо для управления строкой в TryStepForward
int totalItems = n * m;
while (currentValue - 1 != totalItems)
{
    for (int j = 0; j < newArr.GetLength(1) - 1; j++)
    {
        currentValue = TryStepForward(arr: newArr, currentY: lapIndex, currentX: j, currentVal: currentValue);
    }
    newArr = TurnArray(newArr);
    countTurning++;
    if (countTurning == 4) //Проверяю не пора ли сдвинуться на внутренний круг
    {
        lapIndex++;
        countTurning = 0;
    }
}
while (newArr[0, 0] != 1)
{
    newArr = TurnArray(newArr);
}
PrintArray(newArr);

