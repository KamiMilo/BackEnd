Console.WriteLine($"Digite o seu ano de nascimento:");
  int nasc= int.Parse (Console.ReadLine());

//DateTime.now : mostra data e hora atualizada.
//DateOnly.fromdatetime : oculta a hora .
var today = DateOnly.FromDateTime(DateTime.Now);

// subtrai os anos do datetime (irá subtrair pelo ano de nascimento que o a pessoa colocar)
var novaData = today.AddYears(-nasc);

//novaData.Year : mostra apenas o ano.
// Console.WriteLine(novaData.Year);

//multiplica o ano por 52(tanto de semanas em 1 ano)
int semanas = novaData.Year * 52;
Console.WriteLine($"a sua idade atual é de {novaData.Year} anos e  {semanas} semanas");
