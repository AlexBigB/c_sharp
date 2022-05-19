Console.Clear();
Console.Write("Введите числа через пробел: ");
string s = Console.ReadLine();
Console.WriteLine(s);
string[] str_arr=s.Split(' ').ToArray();
Console.WriteLine(str_arr.Length);
int[] array = new int[str_arr.Length];

int[] myStrToInt(string[] s_arr,int[] i_arr)
{   
    int counter = 0;
    while (counter < s_arr.Length)
    {
        i_arr[counter] = int.Parse(s_arr[counter]);
        counter++;
    }
}




Console.WriteLine(i);