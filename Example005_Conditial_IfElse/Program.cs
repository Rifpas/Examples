Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "mari")
{
    Console.WriteLine("Ура, это же Mari");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}