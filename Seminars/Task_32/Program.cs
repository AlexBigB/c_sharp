// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Clear();
Console.Write("Задайте длинну массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArr = new int[size];
var newRnd = new Random(); 
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = newRnd.Next(-99, 100);
    Console.Write($"{myArr[i]}, ");
}
Console.WriteLine();
for (int i = 0; i < myArr.Length; i++) myArr[i] *= -1;
Console.WriteLine(string.Join(", ", myArr));