using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Login
    {
        public bool Logado {get; set;}

        public Login(string email,string senha)
        {
             Console.WriteLine($"Digite o seu Email:");
            email= Console.ReadLine();
            
            Console.WriteLine($"Digite a senha:");
            senha= Console.ReadLine();
        }

         public void Logar ()
         {
            


         }

            public void Deslogar (string Usuario)
         {
            
         }

         public void Menu(){
            
         }
    }
}