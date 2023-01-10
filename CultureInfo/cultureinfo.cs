// CultureInfo
// Utilizamos esse serviço para saber onde o usuario esta e formatar datas de acordo com o local dele
using System;
using System.Globalization;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT"); // Portugues de portugal
            var br = new CultureInfo("pt-BR"); // Precisamos criar uma instancia e passar que tipo de cultura a gente quer aqui.
            var en = new CultureInfo("en-US"); // Estados Unidos
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture; // Se quiser pegar a cultura atual da máquina
            Console.WriteLine(DateTime.Now.ToString("D", pt)); // Formatar data em portugues
            
        }
    }
}