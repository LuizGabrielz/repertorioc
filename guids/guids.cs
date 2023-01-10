// Guids

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); // Criar numeros aleatório
            id.ToString(); // Transformar em uma string, só para aparecer textos

            id =  new Guid(""); // Transformar em texto
            Console.WriteLine(id);
        }
    }
} 