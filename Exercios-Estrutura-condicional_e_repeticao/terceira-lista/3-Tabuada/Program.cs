//Faça um programa que receba um número inteiro e mostre a sua tabuada

int numero=0;
Console.WriteLine($"Digite o número que deseja ver a tabuada:");
numero = int.Parse (Console.ReadLine());

for (int tab = 1; tab <= 10 ; tab++)
{
    Console.WriteLine($"{numero} x {tab}= {tab * numero}");
    
}
