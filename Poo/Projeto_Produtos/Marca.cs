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

       public static List<Marca> Marcas = new List<Marca>();
        // internal static string? marca;

        public void CadrastrarMarca ()
        {
            Marca m1 = new Marca();

            Console.WriteLine($"Marca:");
            NomeMarca= Console.ReadLine();

            Console.WriteLine($"Código:");
            Codigo =Console.ReadLine();
            
            
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

        public void Deletar()
        {
            Console.WriteLine($"Informe o codigo da marca:");
            int codigoMarca= int.Parse (Console.ReadLine());

            Marca m1 = Marcas.Find (x=> codigoMarca );
            
            
        }


    }
}