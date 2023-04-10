//faça um programa que leia o nome de usuario e senha e nao aceite a senha igual o nome.
//mostrando uma mensagem de erro e voltando a pedir as informaçoes
string nome= "";
string senha= "";

do
{
    Console.WriteLine($"Digite seu nome:");
    nome = Console.ReadLine();
    
    Console.WriteLine($"Digite sua senha:");
    senha =Console.ReadLine();
     
    
} while (nome == senha);






