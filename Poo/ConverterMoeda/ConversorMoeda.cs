namespace ConverterMoeda
{

    public static class ConversorMoeda
    {
       public static float Valor;
       public static float  Cotacao;
       public static float Resultado;

    public static float ConverterEmDolar(float Valor, float Cotacao)
    {
      Resultado =  (Valor / Cotacao);
        return Resultado;
    }
    public static float ConverterEmReal(float Valor, float Cotacao)
    {
        Resultado= (Valor * Cotacao);
        return Resultado;
        
    }
       
    }
}