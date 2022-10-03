Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
   Console.Write("Ура, наконец-то это Маша!"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}