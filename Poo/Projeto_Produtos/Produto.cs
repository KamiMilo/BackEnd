using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Produto 
    {
       public Marca marca = new Marca();
        public Usuario usuario = new Usuario();
        public Login login = new Login();

        public int Codigo {get; set;}
        public string NomeProduto {get; set;}
        public float Preco {get; set;}
        public Usuario CadastradoPor = new Usuario();

        public DateTime DataCadrastro {get; set;}= DateTime.Now;

        List<Produto> produtos= new List<Produto>();

        public Produto()
        {
        }

        public Produto(string _nome, int _codigo, float _preco, string marca1)
        {
            NomeProduto = _nome;
            Codigo = _codigo;
            Preco = _preco;
            marca.NomeMarca = marca1;
        }

        public void Cadastrar ()
     { 
        Produto produt =new Produto();

         Console.WriteLine($"Informe o nome do produto:");
         NomeProduto = Console.ReadLine();
         Console.WriteLine($"Informe o codigo:");
         Codigo = int.Parse (Console.ReadLine());
         Console.WriteLine($"Informe o preco :");
         Preco = float.Parse (Console.ReadLine());
         Console.WriteLine($"Informe a Marca:");
         marca.NomeMarca= Console.ReadLine();
           
            produtos.Add(new Produto(NomeProduto,Codigo,Preco,marca.NomeMarca));

            Console.WriteLine($"PRODUTO CADRASTRADO!!");

            Console.WriteLine(@$"
            produto: {NomeProduto}
            código: {Codigo}
            Preço: {Preco}
            Marca:{marca.NomeMarca}
            ");
            
     }

     public void Listar ()
     {
        foreach (var produto in produtos)
        {
            Console.WriteLine($@"
            Nome: {produto.NomeProduto}
            Codigo: {produto.Codigo}
            Preço: {produto.Preco}
            Marca:{item.Marca.NomeMarca}
            ");  
 
        }
            // Console.WriteLine($"Cadastrado por:{login.Nome}");
     }

      public void Deletar ()
       {
            char opcao;

            Console.WriteLine($"informe o nome do produto que deseja deletar:");
            
            string NomepRemover= Console.ReadLine();
                
            do
            {
                Console.WriteLine($"digite (s) para continuar ou (n) pr cancelar");
                opcao = char.Parse(Console.ReadLine().ToLower());

            } while (opcao != 's' && opcao != 'n');

            Produto p1 = produtos.Find(x => x.NomeProduto == NomepRemover);
            int index = produtos.IndexOf(p1);
    
 
         if (opcao == 's')
         {
                produtos.RemoveAt(index);
                Console.WriteLine($"PRODUTO REMOVIDO!!");

            if (opcao == 'n')
            {
                Console.WriteLine($"OPERAÇÃO CANCELADA!!");
            }
                
            }

            else {
                Console.WriteLine($"OPÇÃO INVALIDA!!");
                
            }
            
            
        }


    } 
}