//criar uma classe *Calculadora*  / / Usar PascalCase // do while para repetir o menu
//criar um método para cada uma das operaçoes
//fazer um menu:
// Digite a operação que deseja:
// (+)
// (-)
// (/)
// (*)

using poo_calculadora;

calculadora calc= new calculadora();


Console.WriteLine(@$"BEM-VINDO A CALCULADORA");
System.Console.WriteLine();
Console.WriteLine(@$"Digite a opção que deseja::
 1- (+) 
 2- (-) 
 3- (/)
 4- (*)

 0-Sair 
 ");
 
calc.sinal= char.Parse(Console.ReadLine());

Console.WriteLine($"Informe o primeiro numero:");
calc.n1= float.Parse(Console.ReadLine());


Console.WriteLine($"Informe o segundo Numero:");
calc.n2=float.Parse(Console.ReadLine());

switch (calc.sinal)
{
    case '+':
    calc.soma();
        break;
    case '-':
    calc.subtrair();
       break;
    case '*':
    calc.multiplicar();
    break;
    case '/':
    calc.dividir();
    break;
    default:
        break;
}

Console.WriteLine($"Resultado: {calc.resultado}");
Console.WriteLine($"");

    











