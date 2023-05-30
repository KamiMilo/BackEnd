using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;

namespace Projeto_Gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        //instancia da classe context para acessar o bacno de dados.
        Context c = new Context();

        [Route("Listar")]// http:localhost//Equipe/Listar
        public IActionResult Index()
        {
            //Variável que armazena a lista de esquipes do banco de dados.
            ViewBag.Equipe= c.Equipe.ToList();

            //Retorna a View de equipe
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}