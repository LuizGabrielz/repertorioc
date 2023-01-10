// StringBuilder

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder(); // Construir uma String
            texto.Append("Esre texo é um teste"); // Append adiciona um item nesse texto 
            texto.Append("é um teste");
            texto.Append("Este texto");
            texto.Append("Este um teste");

            Console.WriteLine(texto); // Le a variavel "texto"
        }
    }
} 