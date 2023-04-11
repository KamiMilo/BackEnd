//escreva um programa que receba e imprima nome e idade de 5 pessoas
//exemplo;
//nome:Carlos
//idade: 26 anos

//entrada
string[] nomes=new string[5];
int [] idade= new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um nome");
    nomes[i]= Console.ReadLine();
    
    Console.WriteLine($"Digite uma idade");
    idade[i]= int.Parse (Console.ReadLine());       
}

foreach (var item in nomes)
{
    
}
