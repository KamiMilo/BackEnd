namespace Projeto_celular
{
    public class Celular
    {
        private const int V = 1000;
        public string cor = "verde";
        public string tamanho = "6.7";
        public string modelo = " N981B";
        public bool ligado;

        public string comando;


        public void Ligar()
    {
        if (comando == "s")
        {
                ligado = true;
            }
        else
        {
                ligado = false;
            }
    }

    static void BarraCarregamento(string texto , int quantidadePontinhos, int tempo)
     {
         Console.WriteLine(texto);
         ;
        for (int i = 0; i < quantidadePontinhos; i++)
         {
             Console.WriteLine(".");
            Thread.Sleep(tempo);
        }
    }
    public void Chamada()
    {
        Console.WriteLine($"Digite o número:");
        string numero = Console.ReadLine();
        
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@$"
        Chamando...
        
        ");
         Console.ResetColor();
    }

    public void EnviarMensagem()
    {  
        Console.WriteLine($"Selecione o nome do contato:");
        string nome = Console.ReadLine();
        
        Console.WriteLine($"Digite a Mensagem :");
        string Mensagem = Console.ReadLine();

        Console.WriteLine($"");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"MENSAGEM ENVIADA:");
        Console.WriteLine(nome);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(Mensagem);
         Console.ResetColor();

    }
    
    public void informacoes()
    {
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Tamanho de Tela: {tamanho}");
        Console.WriteLine($"Modelo: {modelo}");
        
    }


    }

}