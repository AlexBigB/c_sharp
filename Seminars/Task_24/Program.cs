// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
int num = int.Parse(Console.ReadLine());
int sum = 0;

int GetSumNumbers (int numb)
{
    int sum = 0;
    for (int i = 0; i <= numb; i++) sum += i;
    return sum;
}




Console.WriteLine($"{num} -> {GetSumNumbers(num)}");