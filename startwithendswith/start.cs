// StartWith/EndsWith (começa com/ termina com)
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este")); // Comparação com a string é igual
            Console.WriteLine(texto.StartsWith("este")); // Comparação com a string é diferente
            Console.WriteLine(texto.StartsWith("texto")); // Diferente da string
            
            Console.WriteLine(texto.EndsWith("teste")); // Termina com "teste" em minusculo é verdadeiro
            Console.WriteLine(texto.EndsWith("Teste")); // Termina com "Teste" em maiusculo é falso, pois não esta igual
            Console.WriteLine(texto.EndsWith("xpro")); // Falso pq não tem nada a ver com a string
        }
    }
}