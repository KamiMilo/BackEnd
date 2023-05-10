using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaArray
{
    public class Produto
    {
        public float Codigo {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;} 


        public Produto()
        {

        }

         public Produto( float codigo,string nome,float preco)
        {
            Codigo= codigo;
            Nome= nome;
            Preco=preco;
        }

    }
}