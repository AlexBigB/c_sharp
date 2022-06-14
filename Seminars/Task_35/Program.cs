// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
int len = 123;
int[] myArr = new int[len];
var myRnd = new Random();
int counter = 0;
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = myRnd.Next(0,123);
    Console.Write($"{myArr[i]}, ");
    if (myArr[i] >=10 && myArr[i] <=99) counter++;
}
Console.WriteLine($" -> {counter}");

