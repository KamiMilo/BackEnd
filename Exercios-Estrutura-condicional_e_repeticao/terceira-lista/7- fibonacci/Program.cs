Console.WriteLine($"série de fibonacci");
int num1=0;
int num2=1;
int auxiliar;

for (int i = 0; i < 500; i++)
{
    auxiliar = num1;
    num1=num2;
    num2= num1+auxiliar;

    Console.WriteLine(num2);
    if(num2 >500)
    {
        Console.ReadLine();
        //ou break; para parar o programa
        
    }
}

