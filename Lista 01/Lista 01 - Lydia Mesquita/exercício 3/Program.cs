// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//atividade 3
Console.WriteLine("Adcione sua pontuação inicial");
int pontos = int.Parse(Console.ReadLine());
if (pontos > 0)
{
    Console.WriteLine("Você já começou pontuando!");
}
else
{
    Console.WriteLine("Você ainda não tem pontos");
}
