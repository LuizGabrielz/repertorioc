// Equals - Outra forma de comparar texto

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));// Texto igual a variável
            Console.WriteLine(texto.Equals("este texto é um teste"));// Texto diferente da variavel
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison));// True pq ele vai converter tudo pra minusculo

        }
    }
}