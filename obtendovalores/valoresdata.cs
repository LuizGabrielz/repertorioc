// Obtendo valores da data

using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = new DateTime(2020, 10, 12, 8, 23, 14); // Data padrão
            // var data = DateTime.Now; // Data de agora
            Console.WriteLine(data);

            Console.WriteLine(data.year);

            Console.WriteLine(data.Month);

            Console.WriteLine(data.day);

            Console.WriteLine(data.Hour);

            Console.WriteLine(data.Minute);

            Console.WriteLine(data.Second);
        }
    }
} 