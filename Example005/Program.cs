// See https://aka.ms/new-console-template for more information

Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine ("Ура,это Маша!");
}
else 
{
    Console.WriteLine("ПРивет, ");
    Console.WriteLine(username);
}


