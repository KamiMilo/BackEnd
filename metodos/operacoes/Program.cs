//criar os métodos para as demais operações matematicas ()
  //receber os números e exibir os resultados

  static float Somar (float N1,float N2 )
{
   return (N1 + N2);
}

static float Subtrair (float N1, float N2)
{
    return (N1 - N2);
}

static float multiplicar (float N1, float N2)
{
    return (N1 * N2);
}

static float dividir (float N1, float N2)
{
    return (N1 / N2);
}

float resultado =0;

for (var i = 0; i < 4; i++)
{
Console.WriteLine($"informe o primeiro número");
float PrimeiroN = float.Parse (Console.ReadLine());

Console.WriteLine($"informe a operacao que deseja:");
char operacao = char.Parse (Console.ReadLine());

Console.WriteLine($"informe o segundo número");
float SegundoN = float.Parse (Console.ReadLine());


switch (operacao)
{
   case '+':
    resultado = Somar(PrimeiroN,SegundoN);
     break;
    case '-':
    resultado = Subtrair(PrimeiroN,SegundoN);
     break;
     case '*':
    resultado = multiplicar(PrimeiroN,SegundoN);
     break;
     case '/':
    resultado = dividir(PrimeiroN,SegundoN);
     break;
}
Console.WriteLine($"o resultado é:{resultado}");
System.Console.WriteLine();

}





