// ForEach
using System;

namespace WorkingWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1,2,3,4,5 }; // int pq é um array de número
            meuArray[0] = 12;

            foreach (var item in meuArray) // Pecorrer cada item do Array
            {
                Console.WriteLine(item);
            }
        }
    }
}