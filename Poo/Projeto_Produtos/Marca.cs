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

        public DateTime DataCadrastro {get;  set;}

       public static List<Marca> Marcas = new List<Marca>();
        // internal static string? marca;

        public void CadrastrarMarca ()
        {
            Marca m1 = new Marca();

            Console.WriteLine($"Marca:");
            string newNomeMarca= Console.ReadLine();

            Console.WriteLine($"Código:");
            int codigo = int.Parse (Console.ReadLine());
            
            
            m1.NomeMarca = newNomeMarca;
            m1.Codigo = codigo;
            m1.DataCadrastro = DateTime.Now;
            Marcas.Add(m1);

        }

        public void Listar()
        {
            foreach (Marca objMarca in Marcas)
            {
                Console.WriteLine(@$"
                Código: {objMarca.Codigo}
                Marca: {objMarca.NomeMarca}
                Data de Cadrastro: {objMarca.DataCadrastro}");       
            }

        }

        public void Deletar()
        {
            Console.WriteLine($"Informe o codigo da marca:");
            int codigoMarca= int.Parse (Console.ReadLine());

            Marca encontrado = Marcas.Find (x=> x.Codigo == codigoMarca);
            int index = Marcas.IndexOf(encontrado);
            Marcas.RemoveAt(index);
        }


    }
}