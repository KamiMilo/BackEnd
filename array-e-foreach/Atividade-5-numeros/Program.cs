// crie um programa em que receba 5 números inteiros e ao final exiba o seu dobro
// voce deve ultilizar a estrutura array com tamanho 5 para armazenar os numero;
// for para leitura dos numeros 
// foreach para exibí-los


//entrada
int[] numeros= new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um número:");
    numeros[i]= int.Parse(Console.ReadLine()); 

}

//processamento e saida
Console.WriteLine($"o dobro desses números é:");

foreach (var item in numeros)
{
    Console.WriteLine(item * 2);
    
}

