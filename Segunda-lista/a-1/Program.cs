//screva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"insira sua data de aniversário: ");

Console.WriteLine($"Dia:");
int day = int.Parse (Console.ReadLine());

Console.WriteLine($" mês:");
int month = int.Parse (Console.ReadLine());

Console.WriteLine($"ano:");
int year = int.Parse (Console.ReadLine());

// var date = new DateTime(2013 ,12 ,31);

if(day > 31 )
{
    Console.WriteLine($"Dia inválido");
    
    if (month > 12)
    {
         Console.WriteLine($"Mês inválido");
    }

    if (year > 2013)
    {
        Console.WriteLine($"ano inválido");
        
    }

    else {
        Console.WriteLine($"**DATA REGISTRADA**");
        
    }
    
}


else if (day > 31 && month > 12 && year >2013)
{
    Console.WriteLine($"DATA INVÁLIDA!!");
    
}




