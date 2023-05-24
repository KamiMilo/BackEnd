using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Login
    {

          Produto produto = new Produto();
          Marca marca = new Marca();
        public bool Logado { get; set; }

        public Login()
        {
            Logar();
            
        }

        public void Logar()
        {
          Usuario user = new Usuario();
            bool senhaEUsuarioCorreto;
            do
            {

                Console.WriteLine($"Digite o seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite a senha de acesso:");
                string senha = Console.ReadLine();
                senhaEUsuarioCorreto = (nome == user.Nome && senha == user.Senha);

                if (senhaEUsuarioCorreto)
                {
                    Console.WriteLine($"USUARIO LOGADO!!\n");
                    Console.WriteLine($"Bem vindo {user.Nome}");
                    Menu();

                }
                else
                {
                    Console.WriteLine($"Usúario incorreto!!");

                }

            } while (!senhaEUsuarioCorreto);

        }



  public void Deslogar ()
{
  Console.WriteLine($"Deseja deslogar do sistema?");
  Console.WriteLine($"responda com s/n");

  char resposta = char.Parse(Console.ReadLine());
  if (resposta == 's')
  {
    Console.WriteLine($"Usuario Deslogado");

  }
}

public void Menu(){
char opcao;
  do
  {
  Console.WriteLine(@$"
  --------------------------
           MENU
  [1]- Cadastrar Produto    
  [2]- Lista de Produtos
  [3]- deletar produto
  [4]- Cadrastar Marca
  [5]- Lista de Marcas
  [6] -Deletar Marca
  [7]- Deslogar
  [0]- Sair do Sistema 
  ");

   opcao= char.Parse (Console.ReadLine());

switch (opcao)
{
  case '1':
   produto.Cadastrar();
  break;
  case '2':
   produto.Listar();
  break;
  case '3':
produto.Deletar(); 
  break;
  case '4':
  marca.CadrastrarMarca();
  break;
  case '5':
  marca.Listar();
  break;
  case '6':
   marca.Deletar();
  break;
  case '7':
   Deslogar();
  break;

  default:
   break;
      }

  } while (opcao != 0);


}

}
} 