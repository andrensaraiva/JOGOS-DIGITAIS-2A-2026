// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 10
Console.WriteLine("Nome do personegem: ");
String nome = Console.ReadLine();
Console.WriteLine("Classe: ");
string classe = Console.ReadLine();
Console.WriteLine("Vida: ");
int Vida = int.Parse(Console.ReadLine());
Console.WriteLine("energia: ");
string energia = Console.ReadLine();
if (Vida ==0)
{
    Console.WriteLine("Vida precisa ser maior que zero");
}
else
{
    Console.WriteLine("Personagem pronto para a aventura");
}