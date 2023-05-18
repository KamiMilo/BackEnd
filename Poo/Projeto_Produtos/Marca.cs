using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos
{
    public class Marca 
    {
        public int Codigo {get;  set;}

        public string NomeMarca {get;  set;}

        public DateTime DataCadrastro {get;  set;}= DateTime.Now;

        List<Marca> Marcas = new List<Marca>();

        public void CadrastrarMarca (string marca)
        {
            Marca m1= new Marca();

            this.NomeMarca = marca;

            Marcas.Add(m1);

        }

        public void Listar()
        {
            foreach (var item in Marcas)
            {
                Console.WriteLine(@$"
                Marca: {item}
                Data de Cadrastro: {DataCadrastro}");       
            }

        }

        public void Deletar(string Marca)
        {

        }


    }
}