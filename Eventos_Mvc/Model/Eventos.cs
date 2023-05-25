using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos_Mvc.Model
{
    public class Eventos
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }



        private const string PATH = "Database/eventos.csv";

        public Eventos()
        {  
          string Pasta = PATH.Split("/")[0];

          if (!Directory.Exists(Pasta))
          {
             Directory.CreateDirectory(Pasta);
          }

          if (!File.Exists(PATH))
          {
             File.Create(PATH);
          }

 
        }

        public List<evento> Ler()
        {
          
        }


     
    }
}