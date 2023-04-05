
Console.WriteLine($"insira o placar do primeiro time a:");
int timeA = int.Parse (Console.ReadLine());

Console.WriteLine($"insira o placar do primeiro time b:");
int timeB = int.Parse (Console.ReadLine());

if (timeA == timeB)
{
    Console.WriteLine($"Empate");
    
}

else if (timeA > timeB)
{
    Console.WriteLine($"Time A venceu");
    
}

else 
{
    Console.WriteLine($"Time B venceu");
    
}



