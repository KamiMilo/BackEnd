//Faça um programa que leia três números e mostre o maior e o menor deles.

double a, b ,c;

Console.WriteLine($"Digite o primeiro numero:");
 a = double.Parse (Console.ReadLine());

Console.WriteLine($"Digite o segundo numero:");
 b = double.Parse (Console.ReadLine());

Console.WriteLine($"Digite o terceiro numero:");
 c = double.Parse (Console.ReadLine());


if (a > b && a > c && c< b )
{
    Console.WriteLine($"O maior numero é : {a}");
    Console.WriteLine($"e o menor é {c}");

}

else if (b >  a && b > c && a < c)
{
    Console.WriteLine($"O maior numero é : {b}");
    Console.WriteLine($"e o menor é {a}");
    
}

else {
    Console.WriteLine($"O maior numero é : {c}");

    Console.WriteLine($"e o menor é {b}");
    
    
}