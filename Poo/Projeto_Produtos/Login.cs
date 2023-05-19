using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Login 
    {

       public Login login = new Login();
       public Produto produto = new Produto();
       public Marca marca = new Marca();
       public Usuario user = new Usuario();
        public bool Logado {get; set;}

        public  Login()
        {
        }

         public void Logar ()
         {
             Console.WriteLine($"Digite o seu nome:");
            Nome= Console.ReadLine();
            
            Console.WriteLine($"Digite a senha de acesso (123*):");
            Senha= Console.ReadLine();

            if (Nome == user.Nome &&  Senha == "123*")
            {
                Logado == true;
                Console.WriteLine($"USUARIO LOGADO!!");
                Console.WriteLine($"");    
                Console.WriteLine($"bem vindo {user.Nome}");

            }   

            else if (Nome != user.Nome && Senha == "123*"  ) {

                Console.WriteLine($"Úsuario incorreto digite novamente");
                Nome = Console.ReadLine();
            }
            else
            {
                 do
                {
                    Console.WriteLine($"senha incorreta Digite novamente:");
                    Senha = Console.ReadLine();

                    

                } while (Nome != user.Nome &&  user.Senha != "123*" );
            
            } 
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
            case ('1'):
            { produto.Cadastrar();}
            break;
            case ('2'):
            { produto.Listar();}
            break;
            case ('3'):
            {produto.Deletar(); }
            break;
            case ('4'):
            {marca.CadrastrarMarca();}
            break;
            case ('5'):
            {marca.Listar();}
            break;
            case ('6'):
            { marca.Deletar();}
            break;
            case ('7'):
            { login.Deslogar();}
            break;
            
            default:
          }
                
            } while (opcao != 0);

            
         }

    }
}