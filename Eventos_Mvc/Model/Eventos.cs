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

        public List<Eventos> Ler()
        {
           List<Eventos> listaDeEventos = new List<Eventos>();
           
           //array que recebe cada linha do csv
           string[] EventosRegistrados = File.ReadAllLines(PATH);

           foreach (var item in EventosRegistrados)
           {
                //array para receber os itens da linha separada por ;
                string[] PropriedadesEvento = item.Split(";");

                Eventos ObjEvento = new Eventos();

                ObjEvento.Nome= (PropriedadesEvento[0]);
                ObjEvento.Descricao= (PropriedadesEvento[1]);
                ObjEvento.Data= (PropriedadesEvento[2]);

                listaDeEventos.Add(ObjEvento);
           }

              return listaDeEventos;
        }


     
    }
} 