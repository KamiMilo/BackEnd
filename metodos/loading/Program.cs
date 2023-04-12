// Console.WriteLine($"Carregando..............");
static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{

for (var i = 0; i <quantidadePontinhos; i++)
{
    Console.WriteLine($".");
    Thread.Sleep (tempo);
    
}
}

BarraCarregamento ("testando", 17,700);


