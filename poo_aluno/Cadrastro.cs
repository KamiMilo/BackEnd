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
        public bool bolsista= true;
        public string resposta;



        public float VerMediaFinal()
        {
           return media;
            
        }

        public float VerMensalidade()
        { 
           
        if (resposta == "sim")
        {
            bolsista = true;
        }
        else
        {
            bolsista = false;
        }

        return 0;

        }




    }
}