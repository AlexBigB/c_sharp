Console.Clear();
int num1 = int.Parse(Console.ReadLine());

void myTask(int someNum)
{
    Console.WriteLine((someNum % 7 == 0) && (someNum % 23 == 0) ? "Multiple with both" : "Not multiple");
}

myTask(num1);