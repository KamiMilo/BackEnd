// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

int tabuada = 1;

    do
    {                   
    Console.WriteLine(@$"
    TABUADA DO {tabuada}");
    Console.WriteLine(@$"
    {tabuada} x {1}= {tabuada*1} 
    {tabuada} x {2}= {tabuada*2} 
    {tabuada} x {3}= {tabuada*3} 
    {tabuada} x {4}= {tabuada*4} 
    {tabuada} x {5}= {tabuada*5} 
    {tabuada} x {6}= {tabuada*6} 
    {tabuada} x {7}= {tabuada*7} 
    {tabuada} x {8}= {tabuada*8} 
    {tabuada} x {9}= {tabuada*9} 
    {tabuada} x {10}= {tabuada*10} 
    ");
    tabuada++;
        
    } while (tabuada <= 10);