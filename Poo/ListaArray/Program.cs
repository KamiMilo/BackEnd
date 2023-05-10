//1.crie uma classe chamada "Produto"
//propriedades: Codigo,nome,preco
//crie um construtor vazio dessa classe
//crie um construtor com todos os atributos
//atalho para o construtor: ctor

//CREATE
//2.Criar lista de objetos (Produtos)

using ListaArray;

List<Produto> produtos= new List<Produto>();

//3.inserir objetos de produtos dentro da lista.

//primeira forma:criado o objeto e inserido direto no Array
//atraves de uma instância direta (com construtor)
produtos.Add(new Produto(1234, "CamisetaLacoste", 49.90f));

//segunda forma: Criado o objeto em uma variável e depois inserido no Array
//através da instância básica de um objeto.
Produto CamisetaArmani= new Produto(1235, "CamisetaArmani", 49.90f);
produtos.Add(CamisetaArmani);

//READ
foreach (var item in produtos)
{
    Console.WriteLine($"Código:{item.Codigo}, Nome:{item.Nome}, Preço: {item.Preco:C}");
    
}

//UPDATE
//acessar um objeto da lista para poder manipulá-lo
Produto produtoEncontrado = produtos.Find(x => x.Codigo == 1235);
int index= produtos.IndexOf(produtoEncontrado);
Console.WriteLine($"o índice do produto encontrado é o : {index}");

//Fazer alterações
produtoEncontrado.Preco= 599f;

//remover o item antigo
produtos.RemoveAt(index);

//devolver o item atualizado
produtos.Insert(index,produtoEncontrado);

foreach (var item in produtos)
{
    Console.WriteLine($"Código:{item.Codigo}, Nome:{item.Nome}, Preço: {item.Preco:C}");
    
}



