// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else


using System.Globalization;

Console.WriteLine($"informe o produto:");
string nome = Console.ReadLine();

Console.WriteLine($"informe a quatidade do produto:");
int quant = int.Parse(Console.ReadLine());

Console.WriteLine($"informe o preço :");
float precoUni = float.Parse(Console.ReadLine());

float total = quant * precoUni;
float desconto = 0.0f;

if (quant<= 5)
{
   desconto = (total / 100) * 2;
}
else if (quant > 5 || quant <= 10)
{
   desconto = (total / 100) * 3;
}

else {
    desconto = (total / 100) * 5;
}

Console.WriteLine($"produto: {nome}");
Console.WriteLine(@$"Total:{Math.Round (total,1).ToString("C", new CultureInfo("pt-BR"))}
Desconto:R${desconto}
Total a Pagar:R${total - desconto}");



