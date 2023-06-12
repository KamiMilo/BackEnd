using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;
using Projeto_Gamer_mvc.Models;

namespace Projeto_Gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        [TempData]
        public string Message { get; set; }
        Context c= new Context();

        [Route("Login")]
        public IActionResult Index()
        {
            //viewbag que traz os dados do usúario.
            //Jogar essa bag nos métodos que retornarem uma view.
           ViewBag.UserName =HttpContext.Session.GetString("UserName");
            return View();
        }


        [Route("Logar")]
        public  IActionResult Logar(IFormCollection form)
        {
            string email =form["Email"].ToString();
            string senha =form["Senha"].ToString();

            Jogador jogadorBuscado = c.Jogador.FirstOrDefault(j=> j.Email == email && j.Senha == senha);

            
            //Aqui precisamos implementar a sessão
            if (jogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName",jogadorBuscado.Nome);

                return LocalRedirect("~/");
            }

              Message= "Dados Inválidos!";
              return LocalRedirect ("~/Login/Login");
            
        }

        [Route("Logout")]
        public  IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");

            return LocalRedirect("~/");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}