using System.ComponentModel.DataAnnotations;

namespace Projeto_Gamer_mvc.Models
{
    public class Equipe
    {
        [Key]//DATA ANNOTATION-IdEquipe
        //só funciona por linha ,no caso aqui só será aplicado ao IdEquipe que está na linha abaixo.
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        // referencia da classe equipe para ter acesso a colection "jogador".
        public ICollection<Jogador> Jogador {get; set;} 
    }
}