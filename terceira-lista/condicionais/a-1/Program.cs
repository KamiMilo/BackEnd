//1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
//ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Digite o ano de seu nascimento");
int anoNasc = int.Parse(Console.ReadLine());

var Idade = DateTime.Now.Year - anoNasc;



 if ( Idade < 16)
 {
     Console.WriteLine($"Você ainda não pode votar!!");
    
 }
 else {
     Console.WriteLine($"já pode votar!!");
    
 }
