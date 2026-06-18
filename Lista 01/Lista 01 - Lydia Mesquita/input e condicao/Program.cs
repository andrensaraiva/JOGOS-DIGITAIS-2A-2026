// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Seu nome é:" + nome);
Console.WriteLine("Escreva sua idade");
int idade = int.Parse(Console.ReadLine());
//int.parse serve pra poder ler números
Console.WriteLine("Sua idade é: " + idade);

//if e else
if (nome == "Phainon")
{
    Console.WriteLine("Bem vindo a Amphoreus Phainon");
}
else
{
    Console.WriteLine("Escreva o nome do Deliver");
}
if (idade >= 26)
{
    Console.WriteLine("Vai passar por ciclos infinitos maninho");
}
else
{
    Console.WriteLine("Essa não é a idade do Deliver");
}
