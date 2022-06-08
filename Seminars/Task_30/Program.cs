// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
int[] int_arr = new int[8];

void FillArray(int[] col1)
{
    Console.Write($"[");
    for (int i = 0; i < col1.Length; i++)
    {
        col1[i] = new Random().Next(0, 2);
        Console.Write($"{col1[i]} ");
    }
    Console.Write($"]");
}

FillArray(int_arr);

