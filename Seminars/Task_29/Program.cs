// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

// Я не до конца понял задание, исходя из примера, получается, что необходимо парсить строку с запятыми, которую ввёл пользователь... 
// В таком случае, получается верно использовать метод работы со строками. Case 1

// Но далее написано, что размер массива определяется пользователем.
// В так случае, получается нужно написать алгоритм заполнения массива произвольной длинны. Case 2

// Case 1
void PrintStrArr(string[] myArr)
{
    Console.Write("[");
    for (int i = 0; i < myArr.Length - 1; i++) Console.Write($"{myArr[i]}, ");
    Console.WriteLine($"{myArr[myArr.Length - 1]}]");
}
Console.Write("Введите все числа через запятую: ");
string s_a = Console.ReadLine();
string[] s_a_arr = s_a.Split(',').ToArray();
PrintStrArr(s_a_arr);

// // Case 2
// void PrintIntArr(int[] myArr)
// {
//     Console.Write("[");
//     for (int i = 0; i < myArr.Length - 1; i++) Console.Write($"{myArr[i]}, ");
//     Console.WriteLine($"{myArr[myArr.Length - 1]}]");
// }
// int[] FillArr(int l, int m)
// {
//     int[] result = new int[l];
//     for (int i = 0; i < result.Length; i++) result[i] = new Random().Next(0, m + 1);
//     return result;
// }

// Console.Write("Задайте длину массива: ");
// int len = int.Parse(Console.ReadLine());
// Console.Write("Задайте максимально допустимое значение для элемента массива: ");
// int maxVal = int.Parse(Console.ReadLine());
// PrintIntArr(FillArr(len, maxVal));

