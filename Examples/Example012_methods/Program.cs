Console.Clear();
// Вид 1
void Method1()
{
    Console.WriteLine("adasdasd");
}

//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//ethod2("aaaa");
System.Console.WriteLine();

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
// Method21("text", 3);
// Method21(count: 4, msg: "some");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

// Console.WriteLine(Method3());

//Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result +text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result +text;
    }
    return result;
}


// string res = Method4(10, "asd");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine("");
// }

//

///////////////////////////////////////////////////////
// Работа с текстом
string myText = "В столовой уже стояли два мальчика, сыновья Манилова," 
            + "которые были в тех летах, когда сажают уже детей за стол,"
            + "но еще на высоких стульях. При них стоял учитель, поклонив­шийся вежливо и с улыбкою."
            + "Хозяйка села за свою суповую чашку; гость был посажен между хозяи­ном и хозяйкою,"
            + "слуга завязал детям на шею салфетки.";

string Replace(string text, char oldvalue, char newvalue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldvalue) result += newvalue;
        else result+= text[i];
    }
    return result;
}

// Console.WriteLine(Replace(myText, ' ', '_'));

int[] arr = {6, 8, 3, 2, 1, 4, 5, 7};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minIndex = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] > array[minIndex]) minIndex = j;
        }
        int tmp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = tmp;

    }
}

PrintArray(arr);
SortArray(arr);
PrintArray(arr);

