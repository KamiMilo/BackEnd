// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:

// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

   int qtdCadastro = 5;
   char  opcao = '0';

string[] nomes = new string[qtdCadastro];
    string[] origens = new string[qtdCadastro];
    string[] destinos = new string[qtdCadastro];
    string[] datas = new string[qtdCadastro];

//LOGIN PARA ENTRAR NO SISTEMA : 
Console.WriteLine(@$"
-----BEM VINDO AO CODE AIRLAINES-------
──────────▄
────────▄██
─▄▀██▀█▀█▀███▀
▀▀▀▀▀████▀▀▀
──────▀██
");
Console.ResetColor();
Console.WriteLine($"");
Console.WriteLine($"digite a senha padrão (12345):");
 string senha = (Console.ReadLine());

    
     while (senha != "12345")
     {
     Console.WriteLine($"Senha incorreta digite novamente:");
    senha = (Console.ReadLine());
     }
     System.Console.WriteLine();
    Console.WriteLine($"**usuario logado**1");

// Menu:
do
{

    Console.WriteLine(@$" 
 ___________________________
|Escolha uma opção do menu: |
|___________________________|
|                           |
| 1- Cadastrar passagem     |
| 2- Listar Passagens       |
| 0- Sair                   |
|___________________________|
");

     opcao = char.Parse(Console.ReadLine());
    char resposta = default;
    switch (opcao)
    {
        case '1':
            // int i = 6;
            do
            {
                cadastroDados(nomes, origens, destinos, datas);
                Console.WriteLine($"Deseja Cadrastrar outro cliente? Digite s/n");
                resposta = char.Parse(Console.ReadLine().ToLower());
            } while (resposta == 's');

            break;
        case '2':
            Console.WriteLine($"PASSAGENS CADASTRADAS:");
            for (var c = 0; c < nomes.Length; c++)
            {
            
                Console.WriteLine($"-------------------------------");
                Console.WriteLine($"");
                
                Console.WriteLine($"Nome:{nomes[c]}");
                Console.WriteLine($"Origem:{origens[c]}");
                Console.WriteLine($"Destino:{destinos[c]}");
                Console.WriteLine($"Data:{datas[c]}");
                Console.WriteLine($"Voo 4440");
                
            }
            break;
        case '0':
            Console.WriteLine($"Fim");
            break;
        default:
            Console.WriteLine($"Opção invalida");
            break;

    }
} while (opcao != 0);

static void cadastroDados(string[] nome, string[] origem, string[] destino, string[] data)
{

  for (int i = 0; i < nome.Length; i++)
  {
    Console.WriteLine($"Digite o nome do passageiro:");
    nome[i]= Console.ReadLine();   
    Console.WriteLine($"");
    
    Console.WriteLine($"qual o estado de origem:");
    origem[i]= Console.ReadLine(); 
    Console.WriteLine($"");

     Console.WriteLine($"qual o destino:");
    destino[i]= Console.ReadLine();
    Console.WriteLine($""); 

    Console.WriteLine($"digite a data:");
    data[i]= Console.ReadLine(); 
    Console.WriteLine($"");
    
  }
}


