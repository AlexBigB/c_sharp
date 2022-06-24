// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int Sum(int numM, int numN)
{
    if (numM < numN)
    {
        return numM == numN ? numM : Sum(numM, numN - 1) + numN;
    }
    if (numM > numN)
    {
        return numN == numM ? numN : Sum(numM - 1, numN) + numM;
    }
    else return numN;
}

Console.Write("Задайте число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{Sum(m, n)}");
