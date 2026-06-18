// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 8
Console.WriteLine("Quantas moedas você tem?");
int moedas = int.Parse(Console.ReadLine());
if (moedas >= 50)
{
    Console.WriteLine("Você pode comprar o item");
}
else
{
    Console.WriteLine("Moedas insuficientes");
}