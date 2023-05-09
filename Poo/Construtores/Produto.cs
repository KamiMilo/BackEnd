using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        //Propriedades
        public string Nome {get; set;}
        public int Codigo {get; set;}

        public int Estoque {get; set;}

        //método construtor Vazio
        public Produto()
        {

        }

        //método construtor com código Obrigatorio
        public Produto(int codigo)
        {
            Codigo= codigo;
        }

         //método construtor com todas as propriedades obrigatorios
          public Produto(string Nome ,int codigo, int estoque)
        {
            Nome= Nome;
            Codigo= codigo;
            Estoque=estoque;
        }


    }
}