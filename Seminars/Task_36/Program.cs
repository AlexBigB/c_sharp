// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Сколько элементов в массиве: ");
int arrLen = int.Parse(Console.ReadLine());
int[] myArr = new int[arrLen];
var myRnd = new Random();
int res = 0;
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = myRnd.Next(0, 10);
    if (i % 2 != 0) res += myArr[i];
}
Console.Write($"[{string.Join(", ", myArr)}] -> {res}");