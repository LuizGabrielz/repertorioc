using System; // Primeiro temos as importações que são sempre definidas pelo using

namespace MeuApp // Divisões lógicas. Vc pode ter arquivos ou pastas com o mesmo nome então vc vai ter conflito.
{
    class Program // Programa em si que é uma classe com tudo que vai ser executado no programa 
    {
        public static void Main(string[] args) // Método Main que é o método principal, então ele sempre vai executar esse método por primeiro.
                                        // Basicamente o que o programa faz é busca o programa.cs, le a classe program e executa o main.
        {
             var texto = "Testando"; 
            Console.WriteLine(texto);
        }
    }
} 