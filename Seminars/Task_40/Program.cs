// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();
Console.WriteLine("Введите длины сторон через пробел: ");
// int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] myArr = {2, 3, 4};
bool res = true;
Console.WriteLine(string.Join(" ", myArr));   
for (int i = 0; i < myArr.Length; i++)
{
    if (i > 0)
    {
        int tmp = myArr[i];
        myArr[i] = myArr[0];
        myArr[0] = tmp;
        // Console.WriteLine(string.Join(" ", myArr));     
    }
    if (myArr[0] > myArr[1] + myArr[2]) res = false;
}
Console.WriteLine(res ? "может" : "не может");