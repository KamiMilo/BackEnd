namespace poo_aluno
{
    public class Cadrastro
    {
        public string nome;
        public string curso;

        public string idade;
        public string rg;


        public float media;
        public float mensalidade;
        public bool bolsista;

        public string resposta;


        public void Bolsis()
        {
            if (this.resposta == "s")
            {
                this.bolsista = true;
            }
            else
            {
                this.bolsista = false;
            }

        }

        public float VerMediaFinal()
        {
           return media;
            
        }

        public float VerMensalidade()
        {  
              if (bolsista == true && media >= 8 )
            {
               mensalidade= mensalidade * 0.5f;
            }

            else if(bolsista == true && media > 6 )
            {
                mensalidade= mensalidade * 0.7f;
            }

            return mensalidade;

        

        }


        

        }





}