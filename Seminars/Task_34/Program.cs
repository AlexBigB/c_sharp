// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Сколько элементов в массиве: ");
int arrLen = int.Parse(Console.ReadLine());
int[] myArr = new int[arrLen];
var myRnd = new Random();
int counter = 0;
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = myRnd.Next(0,1000);
    if (myArr[i] % 2 == 0) counter++;
}
Console.Write($"[{string.Join(", ", myArr)}] -> {counter}");
    
    
    
