// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 14
Console.WriteLine("Qual sua pontuação?");
int rank = int.Parse(Console.ReadLine());
if (rank < 100)
{
    Console.WriteLine("Rank C");
}
if (rank >= 100)
if (rank <= 299)
{
    Console.WriteLine("Rank B");
}
if (rank >=300)
    if (rank <= 499)
    {
        Console.WriteLine("Rank A");
    }
if (rank >= 500)
{
    Console.WriteLine("Rank S");
}