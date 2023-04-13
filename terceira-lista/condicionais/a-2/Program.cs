// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

double G= 5.30;
double A = 4.90;

Console.WriteLine($"qual o tipo de combustivel?");
string tipo= Console.ReadLine().ToLower();

Console.WriteLine($"insira o tanto de litros vendidos");
double litros= double.Parse (Console.ReadLine());

double precoG = (G * litros);
double precoA = (A * litros);
double valor = 0;

if (tipo == "gasolina" && litros < 20)
{
    valor = (precoG /100) * 3;

  if (tipo == "gasolina" && litros > 20)
  {
    valor = (precoG/100) * 5;
  }
}

if (tipo == "alcool" && litros < 20)
{
    valor = (precoA/100) * 4;
    if (tipo == "alcool" && litros > 20)
    {
        valor = (precoA/100) * 6;
    }
    
}
    Console.WriteLine($"O valor a ser pago é {valor}");





