// 6)Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

Console.WriteLine("Digite a media do aluno:");
float media = float.Parse (Console.ReadLine());

Console.WriteLine("Digite a frequencia do aluno:");
float frequencia = float.Parse (Console.ReadLine());

//  float mediamin = 7.0f;
//  float frequenciamin = 75f;
//  float notaminima = 3.0f;


/*avaliacao de frequencia*/
if (frequencia > 75){
/*avaliacao da medi media*/
if (media >= 7) 
{
     Console.WriteLine($"APROVADO"); 
} 
else if (media >= 3 && media < 7)
{
    Console.WriteLine($"RECUPERAÇAO");
}
else {
    Console.WriteLine($"REPROVADO");
    
}
    
}
/*caso frequencia for falso*/
else{
    Console.WriteLine($"REPROVADO por frequencia!!");
}











// if (media >= 7  &&  frequencia >= 75 )
// {
//     Console.WriteLine("**APROVADO**");
    
// }

// else if ( frequencia < 75 )
// {
//     Console.WriteLine($"REPROVADO!!");
    
// }

// else if(media <= mediamin  && media >= notaminima && frequencia <= frequenciamin )
// {
//     Console.WriteLine($"Aluno pode fazer a avaliacao!!");
    
// }


