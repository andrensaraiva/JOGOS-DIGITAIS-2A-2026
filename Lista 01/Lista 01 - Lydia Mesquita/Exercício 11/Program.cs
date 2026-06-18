// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atividade 11
Console.WriteLine("Qual sua vida atual?");
int HP = int.Parse(Console.ReadLine());
Console.WriteLine("Quantidade de cura");
int cura = int.Parse(Console.ReadLine());
int vida_final = cura + HP;
if (vida_final > 100)
{
    Console.WriteLine("HP: 100");
}
else
{
    Console.WriteLine("HP: " + vida_final);
}