// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
int len = 8;
int[] myArr = new int[len];

void MyMethod (int[] a1, int[] a2)
{
    var myRnd = new Random();
    for (int i = 0; i < (a1.Length / 2); i++)
    {
        a1[i] = myRnd.Next(0, 10);
        // Console.WriteLine(string.Join(", ", a1));
        a1[(a1[a1.Length - 1 - i])] = myRnd.Next(1, 10);
        Console.WriteLine($"i = {i}, j = {a1.Length - 1 - i}, a1[(a1[a1.Length - 1 - i] = {a1[(a1[a1.Length - 1 - i])]}");
        //a2[i] = a1[i] * a1[j];
        Console.WriteLine(string.Join(", ", a1));
        // Console.WriteLine(string.Join(", ", a2));
        // Console.WriteLine($"{a1[i]}, ");
        // if (a1[i] >= 10 && a1[i] <= 99) counter++;
    }
}

if (myArr.Length % 2 != 0) 
{
    int[] resArr = new int[(myArr.Length / 2) + 1];
    MyMethod(myArr, resArr);
    Console.WriteLine(string.Join(", ", resArr));
}
else 
{
    int[] resArr = new int[myArr.Length / 2];
    MyMethod(myArr, resArr);
    Console.WriteLine(string.Join(", ", resArr));
}




// if (myArr.Length % 2 != 0)
// {
//     myArr[(myArr.Length / 2)] = myRnd.Next(0, 10);
//     Console.WriteLine(string.Join(", ", myArr));
// }

// Console.WriteLine(string.Join(", ", resArr));
