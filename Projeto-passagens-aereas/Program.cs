// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:

// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

   int senhaLogin = 12345;
   int senha = 0;
   int qtdCadastro = 2;

    string[] nomes = new string[qtdCadastro];
    string[] origens = new string[qtdCadastro];
    string[] destinos = new string[qtdCadastro];
    string[] datas = new string[qtdCadastro];

//LOGIN PARA ENTRAR NO SISTEMA :

/* static void validarSenha (int n1, int n2)
{  
    do
    {
        Console.WriteLine($"Senha incorreta digite novamente:");
         n1 = int.Parse(Console.ReadLine());

    } while (n1 != n2);

     
}
Console.WriteLine($"Digite seu nome:");
Console.ReadLine();

Console.WriteLine($"digite a senha (12345):");
 senha = int.Parse(Console.ReadLine());
 
validarSenha(senha,senhaLogin);
Console.WriteLine($"usuario logado");
 */


Menu:
 Console.WriteLine(@$" 
Escolha uma opção do menu:

 1- Cadastrar passagem
 2- Listar Passagens
 0- Sair");

 char opcao = char.Parse (Console.ReadLine());
 switch (opcao)
 {
    case '1':
    int i =6; 
    Console.WriteLine($"entrar na opçao 1");
        break;
    default:
     case '2':
    Console.WriteLine($"entrar na opção 2");
     break;
    case '0':
    Console.WriteLine($"opcao sair");
    break;
    
 }
  
static void cadastroDados(string[] nome, string[] origem, string[] destino, string[] data)
{

  for (var i = 0; i < 6; i++)
  {
    Console.WriteLine($"Digite o nome do passageiro:");
    nome[i]= Console.ReadLine();   

    Console.WriteLine($"qual o estado de origem:");
    origem[i]= Console.ReadLine(); 

     Console.WriteLine($"qual o destino:");
    destino[i]= Console.ReadLine(); 

    Console.WriteLine($"digite a data:");
    data[i]= Console.ReadLine(); 
    
  }
    
}

cadastroDados(nomes ,origens,destinos,datas);

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Nome:{nomes[i]}");
    Console.WriteLine($"origem:{origens[i]}");
    Console.WriteLine($"origem:{destinos[i]}");
    Console.WriteLine($"origem:{datas[i]}");
    
}