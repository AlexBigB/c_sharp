Console.Clear();
Console.WriteLine("Введите элементы масстива через пробел: ");
int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int index1 = 0;
int index2 = myArr.Length - 1;
while (index1 < index2)
{
    int tmp = myArr[index1];
    myArr[index1] = myArr[index2];
    myArr[index2] = tmp;
    index1++;
    index2--;
}
Console.WriteLine($"{string.Join(" ", myArr)}");