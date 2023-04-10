Console.WriteLine($"Digite o seu salario:");
float salario = float.Parse (Console.ReadLine());


Console.WriteLine($"Digite o seu total de gasto:");
float gasto = float.Parse (Console.ReadLine());

if (salario > gasto)
{
    Console.WriteLine($"gastos dentro do orçamento");

}

else
{
    Console.WriteLine($"orcamento estourado");
    
}



