using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_interface
{
    public class Carrinho : ICarrinho
    {
        //implementar a lógica para cada método
        public float Valor { get; set;}

        //lista onde vamos manipular os objetos
        List<Produto> carrinho = new List<Produto>();
        public void Adiconar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Listar()
        {
            if (carrinho.Count != 0  || carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Código: {p.Codigo} - Nome: {p.Nome} - Preço{p.Preco:C}");
                         
                }
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio!");
                
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo ).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo ).Preco = _novoProduto.Preco;
        }


        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void ValorTotal()
        {
            //+= : Operador de incremento
            Valor = 0;

            if (carrinho.Count > 0 || carrinho !=null)
            {
                foreach (Produto item in carrinho)
                {
                   Valor += item.Preco;
                }

                Console.WriteLine($"O total do seu Carrinho está em : {Valor:C}");
                
            }
            else{
                Console.WriteLine($"Seu Carrinho está Vazio!");
                
            }
            


        }
    }
}