Console.WriteLine("Qual a vida do inimigo?");
Console.WriteLine("Qual a energia do jogador?");
Console.WriteLine("Qual o dano do ataque?");
int Energia = int.Parse(Console.ReadLine());
int Dano = int.Parse(Console.ReadLine());
int Vida = int.Parse(Console.ReadLine());
if (Energia >= 10)
{
    Console.WriteLine("Energia insuficiente para atacar");
}
else
{
    Console.WriteLine("Você pode atacar");
}
if (Dano == Vida)
{
    Console.WriteLine("Inimigo derrotado");
}
else
{
    Console.WriteLine("Vida atual do inimgo é: " + Vida + Dano);
}
