using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Produto
    {
        public int Codigo {get; private set;}
        public string NomeProduto {get; private set;}
        public float Preco {get; private set;}
        public Marca marca = new Marca();

        public Usuario CadastradoPor = new Usuario();

        public DateTime DataCadrastro {get; private set;}= DateTime.Now;

        List<Produto> produtos= new List<Produto>();


     public void Cadastrar (Produto Produto)
     { 
        

     }

     public void Listar ()
     {
        
     }

      public void Deletar ()
      {
        
      }


    } 
}