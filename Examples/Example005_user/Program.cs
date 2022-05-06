Console.Write("Enter user name: ");
string username = Console.ReadLine();
//Console.Write(username);

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}