System.Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "виктор")
{
	System.Console.WriteLine("Приветствую вас, Повелитель");
}
else
{
	System.Console.Write("Здаров, салага! Ну и имя же у тебя стремное... ");
	System.Console.Write(username);
}