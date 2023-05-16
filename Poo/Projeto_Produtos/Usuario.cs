using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Usuario
    {
        Usuario usuario =new Usuario();
        public int CodigoUs {get; private set;}
         public string Email {get; private set;} 
        public string Nome {get; private set;} 
        public string Senha {get; private set;}
         public DateTime DataCadrastroUs {get; set;}= DateTime.Now;

         public string CadastrarUsuario(Usuario usuario)
         {
            return ".";

         }
         public string Deletar (Usuario usuario)
         {
            return ".";
         }



    }
}