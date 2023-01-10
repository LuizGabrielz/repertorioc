// Finally

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
                    Cadastrar("");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Exception.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ops, algo deu errado!");
             }   
             finally // Sempre vai acontecer, independente de erro
             {
                Console.WriteLine("Chegou ao fim!");
             }
        }

        static void Cadastrar(string texto)
        {
              if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }

            public class MinhaException : Exception
            {
                public MinhaException()
                {

                }
                public DateTime QuandoAconteceu { get; set; }
            }
        }
    }  