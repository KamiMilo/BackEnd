//Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
//A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
//Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

Console.WriteLine(@$"
_____________________________
| Escolha uma bebida do menu:|
|___________________________ |
|       Refrigerante         |
|       Café                 |
|       chá                  |
|       Suco                 |
|       limonada             |
|___________________________ |
");

string pedido = Console.ReadLine().ToLower();

switch (pedido)
{
    case "refrigerante":
    Console.WriteLine($"seu pedido foi refrigerante");
      break;
    case "café":
    Console.WriteLine($"seu pedido foi café");
      break;
    case "chá":
    Console.WriteLine($"seu pedido foi chá");
      break;
       case "suco":
    Console.WriteLine($"seu pedido foi suco");
      break;
       case "limonada":
    Console.WriteLine($"seu pedido foi limonada");
      break;
    default:
    Console.WriteLine($"O número do pedido é inválido");
    
        break;
}
if (pedido == "refrigerante" || pedido == "suco" || pedido == "limonada")
{
    Console.WriteLine($" Deseja adicionar gelo? ");
    
   string gelo =Console.ReadLine();

   if (gelo == "sim")
   {
    Console.WriteLine(
@$"*--------------------------------------*
{pedido} com gelo adidional Registrado!!
*--------------------------------------*");
   }
   else {
    Console.WriteLine(
@$"*--------------------------------------*
 {pedido} sem gelo adicional registrado!!
*--------------------------------------*");
    
   }
}
else{
    Console.WriteLine(@$" 
     *----------------------*
     | Pedido resgistrado!! | 
     *----------------------* ");
                            
}















