//EXERCÍCIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

//1 - CRIAR UMA CLASSE "CARRO"
//      - PROPRIEDADES : STRING MARCA, STRING COR

//2 - CRIAR CONSTRUTOR VAZIO E COMPLETO

//3 - CADASTRAR E INSERIR EM UMA LISTA 2 OBJETOS(DINÂMICO)
//      - ENTRADA DE DADOS PELO CONSOLE 

//4 - EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH)


using ativCarros;

List<Carro> carros= new List<Carro>();

for (int i = 0; i < 2; i++)
{
    //criado o objeto para guardar as propriedades.
    Carro carro =new Carro();

    Console.WriteLine($"Qual a Marca do Carro?");
    carro.Marca = Console.ReadLine();

    Console.WriteLine($"Qual a cor do Carro?");
    carro.Cor = Console.ReadLine();
    
    //adiconado o objeto a lista
    carros.Add(carro);
} //[0,1]

foreach (var item in carros)
{
    Console.WriteLine(@$"
    Marca:{item.Marca}
    Cor:{item.Cor}
    ");
    
}







