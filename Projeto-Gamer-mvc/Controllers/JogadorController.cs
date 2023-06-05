using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;

namespace Projeto_Gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        //1- instanciar objeto da classe context para ter acesso ao banco de dados
        Context c =new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            //viewbags para armazenar equipe e jogador
            
            ViewBag.Jogador= c.Jogador.ToList();
            ViewBag.Equipe= c.Equipe.ToList();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}