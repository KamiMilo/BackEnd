//escreva um programa que receba e imprima nome e idade de 5 pessoas
//exemplo;
//nome:Carlos
//idade: 26 anos

//entrada
string[] nomes=new string[5];
int [] idade= new int [5];

for (var i = 0; i < 5; i++)
{
Console.WriteLine(@$"Digite o {i + 1}º nome");
nomes[i]= Console.ReadLine();

Console.WriteLine(@$"Digite a idade");
idade[i]= int.Parse (Console.ReadLine());       
        
}

    for (var i = 0; i <5; i++)
    {
        Console.ForegroundColor=ConsoleColor.DarkBlue;
        Console.WriteLine($"{i + 1})nome: {nomes[i]}");

        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine($"idade: {idade[i]} anos");
        
        Console.WriteLine($"");
        Console.ResetColor();
        
    }