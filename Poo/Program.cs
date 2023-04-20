using Poo;

//instanciando um objeto para a clase main
//trazendo um objeto de outra classe na pasta Poo para a main'.
Personagem p1= new Personagem();

//exibindo informações do objeto
Console.WriteLine($"Digite o nome do seu personagem");
p1.nome= Console.ReadLine();

Console.WriteLine($"Digite o nome do seu personagem");
p1.idade= int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o nome do seu personagem");
p1.armadura= Console.ReadLine();

Console.WriteLine($"Digite o nome do seu personagem");
p1.ia= Console.ReadLine();

//chamando os métodos da classe

Console.WriteLine(@$"
{p1.nome},
{p1.idade},
{p1.armadura},
{p1.ia}
");

p1.atacar();
p1.RestaurarArmadura();
Console.WriteLine(p1.defender());










