Console.WriteLine($"Responda as questões com sim ou não");

Console.WriteLine($"Telefonou para a vítima?");
string telefonou = Console.ReadLine().ToLower();

Console.WriteLine($"Esteve no local do crime?");
string local = Console.ReadLine().ToLower();

Console.WriteLine($"Mora perto da vítima?");
string moraPerto = Console.ReadLine().ToLower();

Console.WriteLine($"Devia para a vítima?");
string devia = Console.ReadLine().ToLower();

Console.WriteLine($"Já trabalhou com a vítima?");
string trabalhou = Console.ReadLine().ToLower();

int contagem= 0;

if (telefonou == "sim")
{
    contagem ++;
}

if (local == "sim")
{
    contagem ++;
}

if (moraPerto == "sim")
{
    contagem ++;
}

if (devia == "sim")
{
    contagem ++;
}

if (trabalhou == "sim")
{
    contagem ++;
}


if (contagem == 2)
{
    Console.WriteLine($"Suspeito");
    
}

else if (contagem == 3 || contagem == 4)
{
    Console.WriteLine($"Cúmplice");
    
}

else {
    Console.WriteLine($"CULPADO!!");
    
}
