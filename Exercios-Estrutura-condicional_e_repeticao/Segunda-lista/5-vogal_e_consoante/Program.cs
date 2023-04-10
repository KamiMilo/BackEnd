//Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.WriteLine($"Digite uma letra e vou identificar se é uma vogal ou consoante:");
string letra = (Console.ReadLine().ToLower());

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" )
{
    Console.WriteLine($"VOGAL");
    
}
else {
    Console.WriteLine($"CONSOANTE");
    
}
