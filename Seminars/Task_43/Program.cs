// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1  // x = (b1- b2)/(k1- k2)
// y = k2 * x + b2; // y = k2(y-k1- b1) + b2 // y = (-k2*k1 - k2*b1 +b2)/(k2 -1)
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 
// -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите переменную b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите переменную k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите переменную b2: ");
float b2 = float.Parse(Console.ReadLine());
Console.Write("Введите переменную k2: ");
float k2 = float.Parse(Console.ReadLine());
float x = (b1- b2)/(k2- k1);
float y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых -> ({x}; {y})");