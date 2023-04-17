// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.


int[] numeros = new int[4];

 for (var i = 0; i < 4; i++)
 {
    Console.WriteLine($"Digite o {i+1}º número:");
    numeros[i] = int.Parse(Console.ReadLine());

}
 

