Console.WriteLine($"Insira a medida de cada lado:");
float LadoA = float.Parse (Console.ReadLine());
float LadoB = float.Parse (Console.ReadLine());
float LadoC = float.Parse (Console.ReadLine());

if (LadoA == LadoB && LadoB == LadoC)
{
    Console.WriteLine("É UM: EQUILATÉRO"); 
}

else if (LadoA == LadoB || LadoB == LadoC || LadoA ==LadoC )
{
    Console.WriteLine($"É UM : ISÓSCELE");
    
}

else
{
    Console.WriteLine($"É UM : ESCALENO");
    
}




