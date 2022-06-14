// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Сколько элементов в массиве: ");
int arrLen = int.Parse(Console.ReadLine());
double[] myArr = new double[arrLen];
var myRnd = new Random();
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = myRnd.Next(0, 100) + Math.Round(myRnd.NextDouble(), 2);
}
double maxValue = myArr.Max();
double minValue = myArr.Min();
Console.Write($"[{string.Join("; ", myArr)}]  -> {maxValue - minValue}");