// Exceptions

using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            for (var index = 0; index < 10; index++)
            {
                // System.IndexOutOfRangeException (isso são erros a serem tratados)
                Console.WriteLine(arr[index]);
            }
        }
    }
}