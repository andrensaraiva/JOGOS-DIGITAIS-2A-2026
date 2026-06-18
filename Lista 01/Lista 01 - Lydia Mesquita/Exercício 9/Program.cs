// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 9
Console.WriteLine("Qual sua vida?");
int vida = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o dano que você recebeu?");
int dano = int.Parse(Console.ReadLine());
int vida_final = vida - dano;
if (vida_final <= 0)
{
    Console.WriteLine("Você foi derrotado");
}
else
{
    Console.WriteLine("Você tem " +  vida_final +  " restante");
}