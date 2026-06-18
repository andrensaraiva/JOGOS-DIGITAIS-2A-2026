// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 4
Console.WriteLine("Qual sua vida?");
int vida = int.Parse(Console.ReadLine());
if (vida > 0)
{
    Console.WriteLine("O jogador ainda está vivo");
}
else
{
    Console.WriteLine("Game Over.");
}
