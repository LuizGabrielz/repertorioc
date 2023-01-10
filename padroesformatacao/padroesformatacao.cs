// Padrões de formatação
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = Strong.Format("{0:D}", data); // Exibe a data por extenso
            var formatada = Strong.Format("{0:t}", data); // short time, só aparece a hora.
            var formatada = Strong.Format("{0:u}", data); // Da um espaço e coloca um z no final
            var formatada = Strong.Format("{0:f}", data); // Junta data e hora
            var formatada = Strong.Format("{0:g}", data); // Junta data e hora, mas na versão short
            var formatada = Strong.Format("{0:y}", data); // Retorna somente o ano 
            Console.WriteLine(formatada);
        }
    }
}  