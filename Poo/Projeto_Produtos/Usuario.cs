using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Usuario
    {
        /* Usuario usuario =new Usuario(); */
        public int CodigoUs {get;  set;}
         public string Email {get;  set;} 
        public string Nome {get;  set;} 
        public string Senha {get;  set;}
         public DateTime DataCadrastroUs {get; set;}= DateTime.Now;

         public void CadastrarUsuario()
         {
            Usuario usuario1= new Usuario();

           Console.WriteLine($"Informe o nome do usuario:");
           Nome = Console.ReadLine();
            Console.WriteLine($"Informe um email:");
           Email = Console.ReadLine();
            Console.WriteLine($"crie uma senha:");
           Senha = Console.ReadLine();

           Console.WriteLine($"Usuario Cadrastrado!!");
         }
         public void Deletar ()
         {
            
            Console.WriteLine($"Deseja deletar esse usuario?");
            Console.WriteLine($"s/n");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {
                Console.WriteLine($" usuario deletado");
                 
            }
             
         }



    }
}