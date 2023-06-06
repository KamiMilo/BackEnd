using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;
using Projeto_Gamer_mvc.Models;

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

        [Route("Cadastrar")]
        public  IActionResult Cadastrar(IFormCollection form)
        {
            //instanciando novo obj para jogador
            Jogador novoJogador= new Jogador();

            //atribui os valores recebidos para o objeto dentro do formulario.
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email=form["Email"].ToString();
            novoJogador.Senha=form["Senha"].ToString();
            novoJogador.IdEquipe=int.Parse(form["IdEquipe"].ToString());

            //salva o obj na lista (viewbag).
            c.Jogador.Add(novoJogador);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }


            [Route("Editar/{id}")]
            public  IActionResult Editar( int id)
            {
                Jogador jogador = c.Jogador.First(x=> x.IdJogador==id);

                //viewbag que guarda o obj jogador desse método
                ViewBag.jogador =jogador;
                //equipes disponíveis para visualizar.
                ViewBag.equipe= c.Equipe.ToList();

                return View("Edit");
            }

           [Route("Atualizar")]
            public  IActionResult Atualizar( IFormCollection form)
            {
                //objeto com os dados do formulario antigo
                Jogador novoJogador= new Jogador();
  
                novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
                novoJogador.Nome= form["Nome"].ToString();
                novoJogador.Email=form["Email"].ToString();
                novoJogador.Senha=form["Senha"].ToString();
                novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());
                

                Jogador jogadorEncontrado = c.Jogador.First(x=> x.IdJogador == novoJogador.IdJogador);
                jogadorEncontrado.Nome=novoJogador.Nome;
                jogadorEncontrado.Email=novoJogador.Email;
                jogadorEncontrado.Senha=novoJogador.Senha;

                c.Jogador.Update(jogadorEncontrado);
                c.SaveChanges();

                return LocalRedirect("~/Jogador/Listar");
            }


            [Route("Excluir/{id}")]
            public  IActionResult Excluir(int id)
            {
                Jogador jogadorEncontrado = c.Jogador.First(e=> e.IdJogador==id);

                c.Remove(jogadorEncontrado);

                c.SaveChanges();

                return LocalRedirect ("~/Jogador/Listar");
            }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}