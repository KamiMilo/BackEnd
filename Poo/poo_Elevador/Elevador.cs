namespace poo_elevador
{
    public class Elevador
    {
       public int Capacidade = 3;
    
       public int[] Andares ={0, 1, 2, 3 };

        public int[] Pessoas;



        //metodos


        static void Inicializa(int Capacidade, int Andares)
     {

     }

        static void Entrar(int[] Pessoas , int Capacidade)
        {
            if (Pessoas[Capacidade] <= Capacidade)
            {
                Console.WriteLine(@$" --------=       =---------");
                Console.WriteLine($"-------------==--------------");
                
                
            }

            else {
                Console.WriteLine($"-----------==----------");
                Console.WriteLine($"O elevador está Cheio");
                
                
            }
            
        }

         static void Sair(int[] Pessoas , int Capacidade)
         {
            if (Pessoas[0] >= Capacidade)
            {
            Console.WriteLine(@$"--------=    =-----------");
            Console.WriteLine($"-----------==--------------");
                
            }

            else
            {
                Console.WriteLine($"O elevador está Vazio");
                
            }
            
         }

          static void Subir()
          {
            
          }

           static void Descer()
           {

           }

    
    }



     
}