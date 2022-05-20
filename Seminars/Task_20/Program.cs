// Ошибка нумерации на семинаре - это была задача под номером 21 для самостоятельного решения

Console.Clear();
Console.Write("Введите координаты а: ");
string s_a = Console.ReadLine();
string[] s_a_arr = s_a.Split(',').ToArray();
double a_x = double.Parse(s_a_arr[0]);
double a_y = double.Parse(s_a_arr[1]);
Console.Write("Введите координат b: ");
string s_b = Console.ReadLine();
string[] s_b_arr = s_b.Split(',').ToArray();
double b_x = double.Parse(s_b_arr[0]);
double b_y = double.Parse(s_b_arr[1]);

double gipotenuza(double x1, double y1, double x2, double y2)
{

    double kat1 = x1 - x2;
    double kat2 = y1 - y2;
    double gip = Math.Sqrt(Math.Pow(kat1, 2) + Math.Pow(kat2, 2));
    Console.WriteLine(Math.Pow(kat1, 2));
    Console.WriteLine(Math.Pow(kat2, 2));
    // gip = Math.Round(gip, 2);
    return gip;
}

double gipo = gipotenuza(a_x, a_y, b_x, b_y);
Console.WriteLine($"{gipo:F}");