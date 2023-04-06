// faça um programa que peça uma nota entre 0 e 10. 
//mostre uma mensagem caso o numero seja inválido 
// continue pedindo até que o valor seja válido

int nota= 0;

do
{
   Console.WriteLine($"Informe uma nota de 0 á 10:");
     nota = int.Parse (Console.ReadLine()); 
    
} while (nota > 10);


  


