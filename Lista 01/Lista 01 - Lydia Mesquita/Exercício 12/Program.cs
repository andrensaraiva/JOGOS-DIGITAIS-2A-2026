// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 12
Console.WriteLine("Escolha um caminho:");
Console.WriteLine("1.FLoresta \n2.Caverna \n3.Castelo");
int Escolha = int.Parse(Console.ReadLine());
if (Escolha == 1)
{
    Console.WriteLine("Você entrou na floresta");
}
if (Escolha == 2)
{
    Console.WriteLine("Você entrou na floresta");
}
if (Escolha == 3)
{
    Console.WriteLine("Você entrou no castelo");
}
else
{
    Console.WriteLine("Opção inválida");
}
