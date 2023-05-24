using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_mvc.Model;

namespace Console_mvc.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produto view
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();


        //método controlador para acessar a listagem de produto
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model, no método Ler.
            List<Produto> produtos= produto.Ler();

            //chamada do método de exibição,recebendo como argumento a lista.
            produtoView.Listar(produtos);

        }
    }
}