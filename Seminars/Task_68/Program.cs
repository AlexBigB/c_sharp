// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int Ancer(int numM, int numN)
{
  if (numM == 0)
    return numN + 1;
  else
    if ((numM != 0) && (numN == 0))
      return Ancer(numM - 1, 1);
    else
      return Ancer(numM - 1, Ancer(numM, numN - 1));
}

Console.Write("Задайте число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{Ancer(m, n)}");