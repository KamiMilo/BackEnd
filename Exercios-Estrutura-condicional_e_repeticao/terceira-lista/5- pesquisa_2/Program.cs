
int homem = 0;
int mulher = 0;
int mediaHomem=0;
int mediaMulher=0;

for (int i = 1; i <= 10; i++)
{
Console.WriteLine($" {i}-Informe sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe seu peso:");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe seu sexo:");
string sexo = Console.ReadLine();   

Console.WriteLine($"______________");

if (sexo == "masculino" )
{
   homem++;
   mediaHomem= idade+idade/ 10;
}
if (sexo== "feminino")
{
   mulher++;
   mediaMulher = idade+idade / 10;
}
}
Console.WriteLine(@$"
Total de Homens:{homem}     
Total de Mulheres:{mulher}      
Média de idade dos Homens:{mediaHomem}      
Média de idade das mulheres:{mediaMulher}
");
