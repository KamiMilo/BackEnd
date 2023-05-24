using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Produto 
    {
       public Marca Marca;
       
        public int Codigo {get; set;}
        public string NomeProduto {get; set;}
        public float Preco {get; set;}
        public Usuario Usuario;

        public DateTime DataCadrastro {get; set;}= DateTime.Now;

        List<Produto> produtos= new List<Produto>();

        Marca objMarca = new Marca();

        public Produto()
        {

        }

        public Produto(string _nome, int _codigo, float _preco, Marca _marca, Usuario _usuario, DateTime _data)
        {
            NomeProduto = _nome;
            Codigo = _codigo;
            Preco = _preco;
            Marca = _marca;
            Usuario = _usuario;
            DataCadrastro = _data;

        }

        public void Cadastrar ()
     { 
        Produto produt =new Produto();

         Console.WriteLine($"Informe o nome do produto:");
          string nomeProduto = Console.ReadLine();
         Console.WriteLine($"Informe o codigo:");
         int codigo = int.Parse (Console.ReadLine());
         Console.WriteLine($"Informe o preco :");
         float preco = float.Parse (Console.ReadLine());
         Console.WriteLine($"informe a marca:");
         string marca= Console.ReadLine();

         Marca encontrado = objMarca.Marcas.Find (x=> x.NomeMarca == marca);
        //  int index = Marca.Marcas(encontrado);
         Marca Marca = encontrado;

            if (encontrado)
           {
            
             
             
           } 


            produtos.Add(new Produto(NomeProduto,Codigo,Preco,Marca, Usuario,DataCadrastro));

            Console.WriteLine($"PRODUTO CADRASTRADO!!");

            Console.WriteLine(@$"
            produto: {NomeProduto}
            código: {Codigo}
            Preço: {Preco}
            ");
            // Marca:{marca.NomeMarca}
            
     }

     public void Listar ()
     {
        foreach (var produto in produtos)
        {
            Console.WriteLine($@"
            Nome: {produto.NomeProduto}
            Codigo: {produto.Codigo}
            Preço: {produto.Preco}
            ");  
            //  Marca:{produto.Marca.NomeMarca}
 
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