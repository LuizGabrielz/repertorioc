// Adicionando Valores 
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12)); // Adicionar dias
            Console.WriteLine(data.AddMonths(1)); // Adicionar messes
            Console.WriteLine(data.AddYears(1)); // Adiconar anos 


            
        }
    }
}  