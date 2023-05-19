using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Usuario
    {
        public int CodigoUs {get; set;} = 3568;
         public string Email {get; set;} = "Code@codigo.com";
        public string Nome {get; set;} ="Admin";
        public string Senha {get; set;} = "123*";
         public DateTime DataCadrastroUs {get; set;}= DateTime.Now;

         public void CadastrarUsuario()
         {

        
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