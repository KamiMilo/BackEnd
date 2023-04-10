//3-Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

double pi = 3.14;

Console.WriteLine($"Qual o Raio da circunferência?");
 double raio= double.Parse (Console.ReadLine());
 
 double diametro = 2 * raio;
 double comprimento= pi * diametro;

if (true)
{
    Console.WriteLine(@$"
o diametro é de : {diametro}
o comprimento é de: {comprimento}
 ");
    
}


