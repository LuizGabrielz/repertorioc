// Structs 
// Definições
// Tipos de dados estruturados
// Apenas a estrutura, o esqueleto
// Tipo de valor
// Armazena apenas outros tipos de dados
// Definido pela palavra struct
// Composto de propiedades e métodos
// Nome sempre com maiúsculo
// O mesmo para propiedades e métodos
// Criado a partir da palavra new 
// Neste momento sim temos os valores

// Definições 
// - A anatomia de uma estrutura normalmente é

/* struct Product
{
    Propiedades

    Métodos
}*/

// Anatomia de uma propiedade

/* struct Product
{
    public int id;
    public float Price;

    public float PriceInDolar (float dolar)
    {
        return Price * dolar;
    }

}*/

// Para criar uma estrutura

/* static void Main(string[] args)
{       
        Cria uma esturutra
    var product = new Product();
}*/

// Vem com dados dos tipos padrão
// Para preencher os dados

/* 
var product = new Product();
product.Id = 1;
product.Title = "Mouse gamer";
product.Price = 197.23f;
Console.WriteLine(product.Id);
Console.WriteLine(product.Title);
Console.WriteLine(product.Price); 
*/

// Método construtor é um método com mesmo nomes da struct

/* struct Product
{
    public Product(int id, string title, float price)
    {
        Id = id;
        Title = title; 
        Price = price;
    }
}*/

// Eles facilitam a criação de estruturas

/* var product = new Producr(1, "Mouse Gamer", 128.75f);
Console.WriteLine(product.Id);
Console.WriteLine(product.Title);
Console.WriteLine(product.Price);
Console.WriteLine(product.PriceInDOlar(5.70f));*/