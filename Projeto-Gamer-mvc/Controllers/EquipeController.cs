using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;
using Projeto_Gamer_mvc.Models;

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

        //instancia da classe context para acessar o banco de dados.
        Context c = new Context();

        //endereço da rota para a tela de equipes 
        [Route("Listar")]// http:localhost//Equipe/Listar
        public IActionResult Index()
        {
            //Variável que armazena a lista de equipes do banco de dados.
            ViewBag.Equipe= c.Equipe.ToList();

            //Retorna a View de equipe
            return View();
        }

        //os dados serão recebidos através de um formulario
        //Iformcollection form= método que retorna um formulario

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            //instanciar obj equipe
            Equipe novaEquipe = new Equipe();

            //atribui os valores recebidos no formúlario para o objeto
            //form =formulario do tipo formulario/ [] =informa o campo a ser atribuido o valor /Tostring= converte do tipo formulario para o tipo do dado (nesse caso string)
            novaEquipe.Nome = form["Nome"].ToString();

            //aqui a imagem estava como string.
            // novaEquipe.Imagem=form["Imagem"].ToString();

            //Inicio da Lógica do upload da imagem
            
            //verificar se tem algum arquivo no formúlario
            //SE EXISTIR ALGUM ARQUIVO.
            if (form.Files.Count > 0)
            {
                //criar váriavel file para armazenar os arquivos 
                //caso tenha um arquivo sera armazenado nessa váriavel
                 var file = form.Files[0];

                //gera caminho para pasta.
                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipes");

                //if para caso não exista a pasta img no wwwroot cria-se.
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //gera o caminho completo até o caminho do arquivo (imagem- nome com extensão)
                var pathCaminho = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img",folder, file.FileName);

                //using para que a instrução dentro dele seja encerrado assim que for executado.
                //Stream dá suporte para a leitura do arquivo.
                using (var stream =new FileStream(pathCaminho, FileMode.Create))
                {
                    file.CopyTo(stream);

                }

                //pega a imagem do file e copia para o stream
                  novaEquipe.Imagem =file.FileName;
            }

                else
                {
                    novaEquipe.Imagem="padrao.png";
                }


            //adiciona objeto na tabela Bd
            c.Equipe.Add(novaEquipe);

            //salva as alteraçòes feitas na Bd
            c.SaveChanges();

            //retorna para o local chamado a rota de listar (método Index)
            //~ = raiz / Equipe/Listar = endereço da rota
            return LocalRedirect ("~/Equipe/Listar");
        }

            //Método excluir que terá como parametro Id da equipe

            [Route("Excluir/{id}")]
            public  IActionResult Excluir(int id)
            {
                Equipe equipeEncontrada = c.Equipe.First(e=> e.IdEquipe==id);

                c.Remove(equipeEncontrada);

                c.SaveChanges();

                return LocalRedirect ("~/Equipe/Listar");
            }

            [Route("Editar/{id}")]




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


      }
}