// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Atividade 5
Console.WriteLine("Qual sua energia?");
int energia = int.Parse(Console.ReadLine());
if (energia >= 10)
{
    Console.WriteLine("Você pode atacar!");
}
else
{
    Console.WriteLine("Energia insuficiente");
}
