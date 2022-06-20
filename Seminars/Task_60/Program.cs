// Задача 60: Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] GetThreeDimArray(int numStrings, int numColumns, int numDepth)
{

    int[,,] myArr = new int[numStrings, numColumns, numDepth];
    int countValues = numStrings * numColumns * numDepth;
    if (countValues > 90)
    {
        Console.WriteLine("Элементов слишком много, массив будет заполнен рандомными занчениями!");
        Random myRnd = new Random();
        for (int i = 0; i < myArr.GetLength(0); i++)
        {
            for (int j = 0; j < myArr.GetLength(1); j++)
            {
                for (int g = 0; g < myArr.GetLength(2); g++)
                {
                    myArr[i, j, g] = myRnd.Next(100);
                }

            }
        }
        return myArr;
    }
    else
    {
        int tmp = 10;
        for (int i = 0; i < myArr.GetLength(0); i++)
        {
            for (int j = 0; j < myArr.GetLength(1); j++)
            {
                for (int g = 0; g < myArr.GetLength(2); g++)
                {
                    myArr[i, j, g] = tmp++;
                }

            }
        }
        return myArr;
    }
}

void PrintThreeDimArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int g = 0; g < arr.GetLength(2); g++)
            {
                Console.Write($"Arr[{i},{j},{g}] = {arr[i, j, g]}, ");
            }
            Console.WriteLine();
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

int x = GetIntVariable("Введите количество элементов по X: ");
int y = GetIntVariable("Введите количество элементов по Y: ");
int z = GetIntVariable("Введите количество элементов по Z: ");
int[,,] bestArr = GetThreeDimArray(x, y, z);
PrintThreeDimArray(bestArr);