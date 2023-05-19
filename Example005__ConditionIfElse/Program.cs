Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "глеб")
{
	Console.WriteLine("Ура, это же Глеб!");
}
else
{
	Console.Write("Привет, ");
	Console.WriteLine(username);
}