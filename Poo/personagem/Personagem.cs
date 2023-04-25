namespace Poo
{
    public class Personagem
    {
        //declarar as propriedades
        //assinatura tipo nome = valor

        public string nome;

        public int idade;

        public string armadura;

         public string ia;


         //Declara Métodos
         public void atacar()
         {
         Console.WriteLine($"O personagem atacou");
         
            
         }

         public string defender()
         {
            return "O personagem defendeu";
            
         }

         public void RestaurarArmadura()
         {
            Console.WriteLine($"o personagem restaurou a armadura");
             
         } 

    }
}