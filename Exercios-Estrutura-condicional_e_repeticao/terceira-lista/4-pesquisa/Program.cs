//entrada

string f = "";
string m ="";
int totalSim =0;
int totalNao=0;
int totalh = 0;
int totalm = 0;
double porcentagemH= 0;

for (var i = 1; i<= 4; i++)
{
Console.WriteLine(@$"
{i}-Digite o seu sexo:
com (F) para feminino e (M) para masculino");
string sexo = Console.ReadLine();
Console.WriteLine(@$"
Você esta satisfeito com nosso produto?
Responda com (Sim)  ou (Não).");
string avaliacao = Console.ReadLine();   
Console.WriteLine($"_____________________________________");
  //processamento
    if(avaliacao == "sim")
    { totalSim++;
    }

    if (avaliacao == "não")
    {totalNao++;
    }

    if(sexo == "f")
    {totalh++;
    }
    
    if (sexo == "m")
    { totalm++;
    }

    if(sexo== "f" && avaliacao =="sim")
    {
      totalm++;
    }

    if (sexo == "m" && avaliacao == "nao")
    {
      porcentagemH= 100 * 10 / porcentagemH;
    }
}
//saida
Console.WriteLine (@$"
Total de Sim: {totalSim}
total de não: {totalNao} 
total de Mulheres que responderam sim: {totalm}
total de homens: {totalh}
homens que responderam não: {porcentagemH}%");
