//------------nome---------------------//
Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

while (nome== "")
{
    Console.WriteLine($"campo *Nome* não pode estar Vazio");
    System.Console.WriteLine("digite novamente:");
    nome = Console.ReadLine();
}

//-------------idade-------------------//
Console.WriteLine($"Digite sua idade:");
int idade = int.Parse (Console.ReadLine());

while (idade > 100 || idade <= 0 )
{
    Console.WriteLine($"Campo *Idade* incoreto: deve ser entre 0 e 100");
    System.Console.WriteLine("digite novamente:");
    idade = int.Parse (Console.ReadLine());
}

//-------------salario-------------------//
Console.WriteLine($"Digite seu salário:");
float salario = float.Parse (Console.ReadLine());

while (salario == 0)
{
    Console.WriteLine($"salário não pode ser igual a 0");
    Console.WriteLine($"Digite novamente:");
    
    salario = float.Parse (Console.ReadLine());
    
}

//--------------estado civíl------------------------//
Console.WriteLine(@$"Digite seu Estado Civil com:
  s para (solteiro(a)),
  c para (casado(a)),
  v para(viuvo(a)),
  d para(divorciado(a):");
  char eCivil = char.Parse (Console.ReadLine());

  while (eCivil != 's' && eCivil != 'c' && eCivil != 'v' && eCivil != 'd')
{
  Console.WriteLine(@$"Digite da forma que foi pedido :
  s para (solteiro(a)),
  c para (casado(a)),
  v para(viuvo(a)),
  d para(divorciado(a)");

    System.Console.WriteLine("digite novamente:");
    eCivil = char.Parse (Console.ReadLine());
    
}

Console.WriteLine($"Informações registradas com Sucesso!!");



