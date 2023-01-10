// Disparando Exceções
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
        }

        static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
            }
        }
    }
}