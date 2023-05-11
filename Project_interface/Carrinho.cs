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
            if (carrinho.Count != 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Código: {p.Codigo} - Nome: {p.Nome} - Preço{p.Preco:C}");
                         
                }
            }
            else
            {
                Console.WriteLine($"Não há produtos no carrinho para listar.");
                
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo ).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo ).Preco = _novoProduto.Preco;
        }


        public void Remover(Produto _produto)
        {
            throw new NotImplementedException();
        }
    }
}