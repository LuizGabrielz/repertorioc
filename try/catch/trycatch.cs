// Try / Catch - Toda vez que uma excessão ocorre ela para a execução do nosso programa
// Corrige os erros
using System;

namespace MyApp
{

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);

                }
                
            }
                catch (exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ops, algo deu errado!");
                }
            }
        }
} 