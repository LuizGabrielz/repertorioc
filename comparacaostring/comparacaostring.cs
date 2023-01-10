// Comparação de String
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto.Contains()); // Compara se o texto é maiusculo ou minusculo
            //Console.WriteLine(texto.CompareTo("Testando"));// Sempre que a gente tem um string a gente tem extensões e uma delas é a comparação, para comparar essa string com algum outro objeto
           //Console.WriteLine(texto.CompareTo("testando")) testando com T maiusculo é diferente que com o t minusculo
            
        }
    }
}  