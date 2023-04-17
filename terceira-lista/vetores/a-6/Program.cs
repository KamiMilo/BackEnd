// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

// string[] nomes = {"Eduardo", "Kamille"};
// int indiceEncotrado = Array.BinarySearch(nomes, "Eduardo");

// Console.WriteLine(indiceEncotrado);

// indiceEncotrado = Array.BinarySearch(nomes, "Kamille");
// Console.WriteLine(indiceEncotrado);


string pesquisa = "";
string[] nomes = new string[10];

for (var i = 0; i < nomes.Length; i++)
{
 Console.WriteLine($" Digite o nome da {i+ 1}º pessoa:");
   nomes[i] =Console.ReadLine();
}

Console.WriteLine($"informe o nome que deseja pesquisar:");
pesquisa= Console.ReadLine();

int buscar = Array.BinarySearch(nomes,pesquisa);

if (buscar>=0)
{
  Console.WriteLine($"ACHEI");
  
}
else
{
  Console.WriteLine($"NÃO ACHEI");
  
}









  
  







