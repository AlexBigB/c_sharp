// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1, 9) -> 11.53

Console.Clear();
Console.Write("Введите координаты а через запятую: ");
string s_a = Console.ReadLine();
string[] s_a_arr = s_a.Split(',').ToArray();
double a_x = double.Parse(s_a_arr[0]);
double a_y = double.Parse(s_a_arr[1]);
double a_z = double.Parse(s_a_arr[2]);
Console.Write("Введите координат b через запятую: ");
string s_b = Console.ReadLine();
string[] s_b_arr = s_b.Split(',').ToArray();
double b_x = double.Parse(s_b_arr[0]);
double b_y = double.Parse(s_b_arr[1]);
double b_z = double.Parse(s_b_arr[2]);

double gipotenuza(double x1, double y1, double z1, double x2, double y2, double z2)
{

    double kat1 = x2 - x1;
    double kat2 = y2 - y1;
    double kat3 = z2 - z1;
    double gip = Math.Sqrt(Math.Pow(kat1, 2) + Math.Pow(kat2, 2) + Math.Pow(kat3, 2));
    // Console.WriteLine(Math.Pow(kat1, 2));
    // Console.WriteLine(Math.Pow(kat2, 2));
    // Console.WriteLine(Math.Pow(kat3, 2));
    gip = Math.Round(gip, 2);
    return gip;
}

double gipo = gipotenuza(a_x, a_y, a_z, b_x, b_y, b_z);
Console.WriteLine($"{gipo:F}");