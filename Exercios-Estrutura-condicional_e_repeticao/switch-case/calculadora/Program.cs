//calculadora com Switch Case

//1. Definir operação 
//2.informar o primeiro numero
//3. informar o segundo número
//4. exibir resultado


Console.WriteLine($@"Informe a operação que deseja usar:
'*'para multiplicar
'+' para somar
'-' para  subtrair
'/' para dividir
");

char operacao =char.Parse (Console.ReadLine());

Console.WriteLine($"Digite o primeiro número:");
float numero1= float.Parse (Console.ReadLine());


Console.WriteLine($"Digite o segundo número:");
float numero2= float.Parse (Console.ReadLine());


float resultado = 0;

switch (operacao)
{
    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine(resultado);
        
        break;

         case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine(resultado);
        break;

         case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine(resultado);
        break;

         case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine(resultado);
        break;

    default: 
    Console.WriteLine($"A operação informada não é suportada pela calculadora");
    
        break;
}

