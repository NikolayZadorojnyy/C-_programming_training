//Приложение, которое будет разных пользователей приветствовать по-разному, 
//а именно: выделим для себя условного любимчика, и наше приложение будет 
//реагировать на него по-особенному.
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")Console.WriteLine("Ура, это же МАША"); 
else
{
Console.WriteLine("Привет ");
Console.WriteLine(username);
}