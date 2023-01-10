// Pecorrendo Array
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]; //{1, 2, 3, 4, 5};
            meuArray[0] = 12;

            for(var index = 0; item < meuArray.Length; index++) {
                Console.WriteLine(meuArray[index]);
            }
        }
    }
}  