using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_mvc.Model;

namespace Console_mvc
{
    public class ProdutoView
    {
        //método para exibir os dados da lista de produtos
        public void Listar(List<Produto> Produto)
        {
            Console.Clear();
            //foreach  para ler a lista passada como Paramêtro
            foreach (var item in Produto)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}\n"); 
            }
        }
    }
}