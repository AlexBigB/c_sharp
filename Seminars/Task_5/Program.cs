Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
num = Math.Abs(num);
int counter = 0-num;
while (counter < num + 1)
{
    Console.Write(counter);
    Console.Write(", ");
    counter ++;
}


