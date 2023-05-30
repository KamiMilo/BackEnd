using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Gamer_mvc.Models
{
    public class Jogador
    {
        [Key] //DATA ANNOTATION- chave primaria
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        [ForeignKey("Equipe")] //DATA ANNOTATION-IdEquipe;referenciado para a classe equipe- (Equipe)nome da tabela que vai fazer a refêrencia para a Chave estrangeira no banco de dados.
        public int IdEquipe { get; set; }
        public Equipe Equipe {get; set;} 
        //precisa ser refêrenciado uma propriedade para equipe.
    }
}