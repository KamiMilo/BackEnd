using Projeto_celular;

string opcao;
Celular ap = new Celular();

Console.WriteLine($"Deseja ligar o telefone? s/n");
ap.comando = Console.ReadLine().ToLower();

if (ap.comando == "s")
{

    do
    {
        Console.WriteLine(@$"
╔═══════════════╗
    BEM-VINDO
╚═══════════════╝");

        Console.WriteLine(@$"
[1]- Fazer Ligação
[2]- Enviar Mensagem
[3]- informações sobre o dispositivo

[0]-Desligar

");

        opcao = Console.ReadLine();


        switch (opcao)
        {
            case "1":
                ap.Chamada();
                break;
            case "2":
                ap.EnviarMensagem();
                break;
            case "3":
                ap.informacoes();
                break;
            default:
                break;
        }

    } while (opcao != "0");

    Console.WriteLine($"esligando...");
    

}
else
{
    Console.WriteLine($"O telefone está desligado");
    
}



    





















