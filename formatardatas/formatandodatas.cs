// Formatando datas

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now; // Para pegar a data de hoje

            var formatada = String.Format("{0:y}", data); // Formatação para ano
            var formatada = String.Format("{0:yyyy/MM/dd}", data); // Formatação para ano, mes e dia
            Console.WriteLine(formatada);

        }
    }
} 