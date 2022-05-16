Console.Clear();

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(collection[index]);
        Console.Write(" ");
        index++;
    }
}

int IndexOf (int[] massiv, int find)
{
    int ind = 0;
    int dlina = massiv.Length;
    int p = -1;
    
    while (ind < dlina)
    {
        if (massiv[ind] == find) 
        {
            p = ind;
            break;
        }
        ind++;
    }
    
    return p;
}


int[] array = new int[10]; //по умолчанию заполнен нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);