// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
Console.Clear();

Console.WriteLine("Введите числа через запятую: ");
int[] numsArr = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //IMPORTATNT!!!
Console.WriteLine(string.Join(' ', (numsArr[0] + numsArr[numsArr.Length-1])));
int positive = 0, negative = 0;
for (int i = 0; i < numsArr.Length; i++)
{
    if (numsArr[i]>0) positive += numsArr[i];
    else negative+= numsArr[i];
}

Console.WriteLine($"Позитивная сумма {positive}, негативная сумма {negative}");





//Console.Write("Задайте размер массива:");
// int size = int.Parse(Console.ReadLine());
// int[] nums = new int[size];
// for (int i = 0; i<nums.Length; i++) 
// {
//     nums[i] = new Random().Next(-9, 10);
//     Console.Write($"{nums[i]},");
// }
// Console.WriteLine("");
// int positive = 0, negative = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i]>0) positive += nums[i];
//     else negative+= nums[i];
// }

// Console.WriteLine($"Позитивная сумма {positive}, негативная сумма {negative}");
