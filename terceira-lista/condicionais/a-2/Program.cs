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

static float total (float n1, float n2)
{
   float D= n1 * n2;
    return D;
}

float a = 4.90f;
float g = 5.30f;

Console.WriteLine($"Digite o combustivel com A para alcool e G para gasolina:");
string combustivel = Console.ReadLine().ToLower();

Console.WriteLine($"Digite a quantidade de litros que deseja:");
float litros = float.Parse (Console.ReadLine());

if (combustivel == "a" && litros < 20.0)
{
    float desconto = (float)(total(a, litros) * 0.3);
    Console.WriteLine($"total a pagar é: {total(a,litros) - desconto}");
    
}
else if (combustivel== "a" && litros > 20.0)
{
    float desconto = (float)(total(a, litros) * 0.5);
    Console.WriteLine($"total a pagar é: {total(a,litros) - desconto}");
    
}
else if (combustivel == "g" && litros < 20.0)
{
   float desconto = (float)(total(g, litros) * 0.4);
    Console.WriteLine($"total a pagar é: {total(a,litros) - desconto}");
}

else if (combustivel == "g" && litros > 20.0)
{
  float desconto = (float)(total(g, litros) * 0.6);
 Console.WriteLine($"total a pagar é: {total(a,litros) - desconto}");
}

else
{
    Console.WriteLine($"valor invalido");

}









