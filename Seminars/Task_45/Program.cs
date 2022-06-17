// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
Console.Clear();
Console.WriteLine("Введите элементы масстива через пробел: ");
int[] baseArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] resArr = new int[baseArr.Length];
for (int i = 0; i < baseArr.Length; i++)
{
    resArr[i] = baseArr[i];
}
Console.WriteLine($"{string.Join(" ", resArr)}");