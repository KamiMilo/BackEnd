// Os produtos terão os seguintes atributos:

// .string Nome
// .float Preco
// .bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:

// .CadastrarProduto
// .ListarProdutos
// .MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

int count = 3;
char opcao;
string[] produtos = new string[count];
float[] preco = new float[count];
bool promocao;
string resposta;

static void validarPromo(string resposta, bool promoção)
{
    if (resposta == "sim")
    {
         promoção = true;
        Console.WriteLine($"Produto em promoção");
    }
    else{
        promoção = false;
    }

}

static void cadastro(string[] nome)
{
    for (int i = 0; i < nome.Length; i++)
    {
     Console.WriteLine($"Nome do produto:");
     nome[i]= Console.ReadLine();
     
        
    }
  
}

do
{
    Console.WriteLine(@$"
Escolha uma opção do menu:
1-cadrastrar produto
2-Listar produto
3-mostrar menu
");

    opcao = char.Parse(Console.ReadLine());
    switch (opcao)
    {
        case '1':
            cadastro(produtos);
            break;
        case '2':
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"Produto:{produtos[i]}");

            }
            break;
        default:
            break;
    }

} while (opcao != 3);







