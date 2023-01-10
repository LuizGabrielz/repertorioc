// Array

using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]; // Array de 5 posições e começa sempre do 0
            // No C# é tipado
            // Podemos tb colocar outro tipo, por exemplo uma string
            var meuArray = new Teste[2];
            meuArray[0] = new Teste(); // Inicializa aqui em baixo
            Console.WriteLine(meuArray[0].Id);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);
            Console.WriteLine(meuArray[5]);
        }
    }
} 