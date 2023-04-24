namespace poo_calculadora
{
    public class calculadora
    {
        public float n1;
        public float n2;
        public char sinal;

        public float resultado;

        public float soma()
    {
        resultado = n1+n2;
       
        return resultado;
            
    }

         public float subtrair()
    {

        resultado = n1-n2;
       
        return resultado;
            
    }

        public float multiplicar()
    {

        resultado = n1*n2;
       
        return resultado;
            
    }

          public float dividir()
    {
            
        resultado = n1/n2;
       
        return resultado;
            
    }






    }
}