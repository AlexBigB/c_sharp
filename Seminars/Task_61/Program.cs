// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод
// в виде равнобедренного треугольника

Console.Clear();

int GetIntVariable(string message)
{
    Console.Write(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

void PrintPascalTriangle(int numRows)
{
    Console.WriteLine("1");
    // Console.WriteLine("1 1");
    int[] firstTmpRow = new int[2];
    firstTmpRow[0] = 1;
    firstTmpRow[1] = 1;
    Console.WriteLine(string.Join(' ', firstTmpRow));
    for (int lenRow = 2; lenRow < numRows; lenRow++)
    {
        int[] secondTmpRow = new int[lenRow + 1];
        secondTmpRow[0] = 1;
        secondTmpRow[lenRow] = 1;
        for (int i = 1; i < secondTmpRow.Length - 1; i++)
        {
            secondTmpRow[i] = firstTmpRow[i - 1] + firstTmpRow[i];
        }
        firstTmpRow = secondTmpRow;
        Console.WriteLine(string.Join(' ', secondTmpRow));
    }
}

int n = GetIntVariable("Сколько строк из треугольника Паскаля вывести? ");
PrintPascalTriangle(n);