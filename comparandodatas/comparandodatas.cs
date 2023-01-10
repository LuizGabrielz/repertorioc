// Comparando Datas
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now; 

            if (data.Date == DateTime.Now.Date) // Também pode ser usado com o simblo de maior >
                Console.WriteLine("É igual");

            Console.WriteLine(data);
        }
    }
}  