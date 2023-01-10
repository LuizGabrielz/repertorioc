// Math

using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;
            Console.WriteLine(valor);
                Math.Round(valor); // Arredonda o valor
                Math.Ceiling(valor); // Arredonda pra cima
                Math.Floor(valor); // Arredonda pra baixo
        }
    }
} 