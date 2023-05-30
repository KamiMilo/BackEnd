using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos_Mvc.Model;
using Eventos_Mvc.View;

namespace Eventos_Mvc.Controller
{
    public class EventoControlador
    {
       Eventos evento = new Eventos();
       EventosView view = new EventosView();

       public void listarEventos()
       {
          List<Eventos> eventos = evento.Ler();
       }
       
    }
}