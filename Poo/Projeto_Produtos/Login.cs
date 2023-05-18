using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Login :Usuario
    {
        Usuario user = new Usuario();
        public bool Logado {get; set;}

        public  Login()
        {
        }

         public void Logar ()
         {
             Console.WriteLine($"Digite o seu nome:");
           user.Nome= Console.ReadLine();
            
            Console.WriteLine($"Digite a senha de acesso (123*):");
           user.Senha= Console.ReadLine();

            if (user.Senha != "123*")
            {
                    do
                {
                    Console.WriteLine($"senha incorreta Digite novamente:");
                    user.Senha = Console.ReadLine();

                    

                } while (user.Senha != "123*");

            }   
            else
            {
            
                Console.WriteLine($"USUARIO LOGADO!!");
                Console.WriteLine($"");    
                Console.WriteLine($"bem vindo {user.Nome}");
            
            } 


         }

            public void Deslogar ()
         {
            Console.WriteLine($"Deseja deslogar do sistema?");
            Console.WriteLine($"responda com s/n");
            
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's')
            {
               BarraCarregamento("Deslogando", 6, 100);
            }

        }

         public void Menu(){
            
         }


          static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Console.WriteLine(texto);
            
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                Console.WriteLine($".");
                Thread.Sleep(tempo);
            }
        }
    }
}