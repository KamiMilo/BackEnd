//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda 

using System.Globalization;

static double ImpostoRenda (double renda)
{
    if (renda <= 1500)
    {
     return 0;
           
    }
    else if (renda >1500 && renda <= 3500)
    {
        return (renda / 100) * 20;
    }
    else if(renda>= 3501 && renda < 6000)
    {
        return (renda/ 100) * 25;
    }

    else {

        return (renda / 100) * 35;
    }
}

Console.WriteLine($"Informe sua renda:");
double salario = double.Parse (Console.ReadLine());

double imposto = ImpostoRenda(salario);
Console.WriteLine(@$"
salario:{Math.Round(salario, 2).ToString("C", new CultureInfo("pt-BR"))}
o valor do imposto é de: R${imposto}");


//.ToString("C", new CultureInfo("pt-BR")): converte a forma de escrita da moeda do pais,


