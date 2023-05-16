using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Marca 
    {
        public int Codigo {get; private set;}

        public string NomeMarca {get; private set;}

        public DateTime DataCadrastro {get; private set;}= DateTime.Now;

        List<Marca> Marcas = new List<Marca>();

        public string CadrastrarMarca (Marca marca)
        {
            return ".";
        }

        public void Listar()
        {

        }

        public void Deletar(string Marca)
        {

        }


    }
}