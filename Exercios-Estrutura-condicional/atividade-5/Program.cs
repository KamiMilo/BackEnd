Console.WriteLine($"digite o numero de maças que comprou:");
int maças = int.Parse (Console.ReadLine());

float menorduzia = 0.30f;
float maiorduzia = 0.25f;

if (maças <= menorduzia)
{
    Console.WriteLine(" o total das  maças é de R$" + maças *menorduzia );
    
}

else

{
    Console.WriteLine ( $" o total das  maças é de R$" + maças * maiorduzia,"reais");
    
}


