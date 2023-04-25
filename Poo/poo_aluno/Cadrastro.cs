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

        public float VerMediaFinal()
        {
           return media;
            
        }

        public void VerMensalidade()
        { 
        if (resposta == "sim")
        {
            bolsista = true;
        }
        else
        {
            bolsista = false;
        }

        }


        public float CalcMensalidade()
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