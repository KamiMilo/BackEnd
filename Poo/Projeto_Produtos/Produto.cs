using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string NomeProduto {get; set;}
        public float Preco {get; set;}
        public Marca marca = new Marca();

        public Usuario CadastradoPor = new Usuario();

        public DateTime DataCadrastro {get;  set;}= DateTime.Now;

        List<Produto> produtos= new List<Produto>();



     public void Cadastrar ( )
     { 
        Produto produt =new Produto();

         Console.WriteLine($"Informe o nome do produto:");
         NomeProduto = Console.ReadLine();
         Console.WriteLine($"Informe o codigo:");
         Codigo = int.Parse (Console.ReadLine());
         Console.WriteLine($"Informe o preco :");
         Preco = float.Parse (Console.ReadLine());
         Console.WriteLine($"Informe a Marca:");
         marca.NomeMarca = Console.ReadLine();
        
         produtos.Add(produt);

         Console.WriteLine($"Produto Cadrastrado!!");
    
     }

     public void Listar ()
     {
        foreach (var produto in produtos)
        {
            Console.WriteLine($@"
            Nome: {produto.NomeProduto}
            Codigo: {produto.Preco}
            Preço: {produto.Preco}
            Marca:{produto.marca}
            ");
            
        }
     }

      public void Deletar (Produto NomeProduto)
      {
        produtos.RemoveAt();
      }


    } 
}