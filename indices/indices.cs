// Indices - Sempre que vc ve o index ele esta se referindo a posição do array
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é")); //Indexof mostra a posição em que a palavra está
            Console.WriteLine(texto.LastIndexOf("s")); // Ultimo item que ele encontrar de uma letra ou uma palavra

        }
    }
} 