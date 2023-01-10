// Interpolação de string
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2; // É um double
            //var texto = "O preço do produto é " + price; // Quando a gente usa um sinal de + ele vai imprimir o valor de price.
            // Outra forma de fazer 
            //var texto = string.Format("O preço do produto é {0} apenas na promoção", price); // O string.format pega esse texto e quando chega no{0} ele vai substituir por um valor, que esta depois da virgula
            // Ultima forma de fazer
            var texto = $"O preço do produto é {price} apenas na promoção"; // Pegar o valor de price
            
            Console.WriteLine(texto);
        }
    }
} 