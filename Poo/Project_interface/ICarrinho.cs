using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_interface
{
    public interface ICarrinho
    {
        //definir quais os metodos deverão ser implementados na classe
        //na classe que herdar a interface

        //CRUD: create / Read / Update /Delete 

        //Create
        void Adiconar(Produto _produto);

        //Read 
        void Listar();

        //update 
        void Atualizar(int _codigo ,Produto produto);
        
        //Delete
        void Remover(Produto _produto);
        

    }
}