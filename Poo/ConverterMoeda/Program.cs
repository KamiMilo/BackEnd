using System.Globalization;
using ConverterMoeda;

//Menu

Console.WriteLine(@$"
O que deseja Converter?
1-Real Para Dolar
2-Dólar para Real
0- Sair
");

string opcao= Console.ReadLine();
Console.WriteLine($"Qual o Valor?");
ConversorMoeda.Valor= float.Parse (Console.ReadLine());

Console.WriteLine($"Qual a cotação?");
ConversorMoeda.Cotacao= float.Parse (Console.ReadLine());

switch (opcao)
{
    case "1":
    Console.WriteLine($"O valor é de {ConversorMoeda.ConverterEmDolar(ConversorMoeda.Valor, ConversorMoeda.Cotacao).ToString("C",CultureInfo.CreateSpecificCulture("en- US"))}");
        break;
    case "2":
    Console.WriteLine($"O valor é de {ConversorMoeda.ConverterEmReal(ConversorMoeda.Valor, ConversorMoeda.Cotacao).ToString("C",CultureInfo.CreateSpecificCulture ("Pt-BR"))}");
    break;
    default:
        break;
}



