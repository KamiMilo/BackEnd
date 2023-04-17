// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:

// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

//LOGIN PARA ENTRAR NO SISTEMA :
int senhaLogin = 12345;

static void validarLogin (int n1,int n2)
{
    if (n1 == n2)
    {
        Console.WriteLine($"USÚARIO LOGADO!!"); 
    }

}
Console.WriteLine($"Digite seu nome:");
Console.ReadLine();

Console.WriteLine($"digite a senha (12345):");
int senha = int.Parse(Console.ReadLine());

validarLogin(senhaLogin,senha);


// static void menu ()
// { 

// }

// static string passagem()
// {

// }