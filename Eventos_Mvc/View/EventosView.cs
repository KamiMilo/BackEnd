using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos_Mvc.Model;

namespace Eventos_Mvc.View
{
    public class EventosView
    {
        Eventos evento = new Eventos();

        public void Listar( List<Eventos> evento)
        {
           foreach (var item in evento)
           {
             Console.WriteLine($"Nome: {item.Nome}");
             Console.WriteLine($"Descrição: {item.Descricao}");
             Console.WriteLine($"Data: {item.Descricao}");
           }
            
        }
    }
}