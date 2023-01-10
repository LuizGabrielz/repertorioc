// Métodos Adicionais

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower()); // Vai converter todo o texto para minusculo
            Console.WriteLine(texto.ToUpper()); // Vai converter o texto todo para maiusculo
            Console.WriteLine(texto.Insert(5, "AQUI")); // Inserir um caractere no meu texto
            // Ele vai inserir na posição 5 a palavra "aqui"
            Console.WriteLine(texto.Remove(5, 5)); // Ele vai pedir o inicio e o fim que vc quer remover 
            Console.WriteLine(texto.Length); // Quantidade de caracteres que uma frase tem
        }
    }
}