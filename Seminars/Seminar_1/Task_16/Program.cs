Console.Clear();
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

void myTask(int someNum1, int someNum2)
{
    Console.WriteLine((someNum2 / someNum1 == someNum1) || (someNum1 / someNum2 == someNum2) ? "Yes" : "No");
}
myTask(num1, num2);
