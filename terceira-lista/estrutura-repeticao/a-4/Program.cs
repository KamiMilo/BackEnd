//4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
//menor valor lido.

    int i = 0;

do
{

    Console.WriteLine($"Digite o {i + 1}º numero:");
   float numero = float.Parse(Console.ReadLine());
    i++;

    float maiorNum = Math.Max(numero ,numero);
    float menorNum = Math.Min(numero ,numero);

} while (i < 4);

    Console.WriteLine($"Maior: {maiorNum}");
    Console.WriteLine($"Menor: {menorNum}");

















