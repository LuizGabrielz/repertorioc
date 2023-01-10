// Manipulando Strings

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "isto")); // Trocar a palavra "Este" por "Isto"
            
            var divisao = texto.plit(" "); // Repartir o texto
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            
            var resultado = texto.Substring(5, 5); // Pega o caracterer numero 5 que vai ser a palavra "texto"
            var resultado = texto.Substring(5, texto.LastIndexOf("o")); // Pega o caractere 5 ate a letra "o"
            Console.WriteLine(resultado);
        }
    }
}  