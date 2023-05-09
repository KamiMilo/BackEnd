// //classe estática 
//     public static class ConversorTemperatura
//     {
//         //membro estático
//         public static float Temperatura { get; set; }       
        

//         //método estático para converter temperatura de celsius para fahreinheit
//         public static float CelsiusParaFahrenheit(float temperaturaCelsius)
//         {
//             //lógica da função
//             //converter

//             Temperatura = temperaturaCelsius;

//             float fahreinheit = (Temperatura * 1.8f) + 32; 

//             return fahreinheit;
//         }   

//         public static float FahreinheitParaCelsius(float temperaturaFahrenheit)
//         {
//             //lógica da função
//             //converter

//             Temperatura = temperaturaFahrenheit;

//             float celsius = (Temperatura - 32) * .55f;

//             return celsius;
//         }
//     }


// *****************************************************************************************

// Console.WriteLine(ConversorTemperatura.CelsiusParaFahrenheit(30));

// Console.WriteLine(ConversorTemperatura.FahreinheitParaCelsius(100));

//para invocar o método estático aqui na program.cs precisamos apenas 
//chamar o nome da classe e a função, não sendo necessário instanciar objetos
//ConversorTemperatura.FahreinheitParaCelsius(100);
//ConversorTemperatura.CelsiusParaFahrenheit(30);
