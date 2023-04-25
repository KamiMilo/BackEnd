
using poo_aluno;

Cadrastro c1 = new Cadrastro();

Console.WriteLine($"Digite o nome");
c1.nome= Console.ReadLine();

Console.WriteLine($"Digite o idade");
c1.idade= Console.ReadLine();

Console.WriteLine($"Digite o curso");
c1.curso= Console.ReadLine();

Console.WriteLine($"Digite o RG");
c1.rg= Console.ReadLine();

Console.WriteLine($"Qual a média do aluno?");
c1.media= float.Parse (Console.ReadLine());

Console.WriteLine($"Qual o valor da Mensalidade?");
c1.mensalidade= float.Parse (Console.ReadLine());

Console.WriteLine(@$"
O aluno é bolsista? digite sim ou não");
c1.resposta= Console.ReadLine().ToLower();

Console.WriteLine(@$"
Aluno:{c1.nome}
idade:{c1.idade}
curso:{c1.curso}
RG: {c1.rg}
");

string opcao;
do
{

Console.WriteLine(@$"
Digite uma opção do Menu

(1) -ver média
(2)- ver Mensalidade
(0)- sair");
opcao = Console.ReadLine();


switch (opcao)
{
    case "1":
    Console.WriteLine($"A media é de: {c1.VerMediaFinal()}");
        break;
    case "2":
    Console.WriteLine($"mesnalidade:{c1.CalcMensalidade()} ");
       break;
    case "0":
    break;
    default:
        break;
}
    
} while (opcao != "0");


