// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

int tab = 1;


    do
    {                   
    Console.WriteLine($"|TABUDA DO {tab}|");
    Console.WriteLine(@$"
    {tab} x {1}= {tab*1} 
    {tab} x {2}= {tab*2} 
    {tab} x {3}= {tab*3} 
    {tab} x {4}= {tab*4} 
    {tab} x {5}= {tab*5} 
    {tab} x {6}= {tab*6} 
    {tab} x {7}= {tab*7} 
    {tab} x {8}= {tab*8} 
    {tab} x {9}= {tab*9} 
    {tab} x {10}= {tab*10} 
    ");
    tab++;
        
    } while (tab <= 10);

    

