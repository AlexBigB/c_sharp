// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();
Console.Write("Задайте искомое число: ");
int myNum = int.Parse(Console.ReadLine());
Console.Write("Задайте длинну массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArr = new int[size];
var newRnd = new Random(); 
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = newRnd.Next(0, 9);
    Console.Write($"{myArr[i]}, ");
}
Console.WriteLine();
bool result = false;
for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] == myNum) result = true;
}
Console.WriteLine(result? "Есть" : "Нет такого числа");
