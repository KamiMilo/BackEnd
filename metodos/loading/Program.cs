static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Write(texto);

    for (var i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);        
    }  
    Console.ResetColor();  
}

BarraCarregamento("Testando",15,700);

BarraCarregamento("Finalizando",20,400);




