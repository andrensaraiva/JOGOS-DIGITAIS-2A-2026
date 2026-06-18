// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 13
Console.WriteLine("Nível do jogador: ");
int nível = int.Parse(Console.ReadLine());
if (nível <5)
{
    Console.WriteLine("Você é iníciante");
}
if (nível >=5)
if (nível <= 10)
{
    Console.WriteLine("Você é aventureiro");
}
if (nível > 10)
{
    Console.WriteLine("Você é Herói experiente");
}