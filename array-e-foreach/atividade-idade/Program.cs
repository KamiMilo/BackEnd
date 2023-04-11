//escreva um programa que receba e imprima nome e idade de 5 pessoas
//exemplo;
//nome:Carlos
//idade: 26 anos

//entrada
string[] nomes=new string[5];
int [] idade= new int [5];

for (var i = 0; i < 5; i++)
{
Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.WriteLine(@$"{i}-Digite um nome");
Console.ForegroundColor= ConsoleColor.White;
nomes[i]= Console.ReadLine();

Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.WriteLine(@$"Digite uma idade");
Console.ForegroundColor= ConsoleColor.White;
idade[i]= int.Parse (Console.ReadLine());       
        
}

    for (var i = 0; i <5; i++)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("nome:" +nomes[i]);
        Console.WriteLine($"_________________");
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("idade:" + idade[i]);
        
    }