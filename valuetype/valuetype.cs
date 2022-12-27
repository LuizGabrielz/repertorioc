// Value Type e References Types
// Definições

// A memória é dividida em duas partes, Heap e Stack
// Heap armazena os dados
// Stack armazena as referencias para os dados
// Qualquer tipo no .NET é tratado como
// Tipo de Referencia (Reference Type)
// Tipo de Valor (Value Type)
// Tipos de valor armazenam dados
// São armazenados em um local da memória chamada Stack
// Quando armazenamos um valor, a memória é alocada
// Este espaço armazena o dado criado
// Nossa variável acessa este dado diretamente
// Se assimilarmos uma variável do tipo de valor a outra
// O valor será COPIADO
// Ambas serão independentes 
// Built-in, Structs, Enums
// Garbage Collector não acessa o Stack
// Visão a nível de código
// int x = 25;
// int y = x; Y é uma cópia de x
// Console.WriteLine(x); 25
// Console.WriteLine(y); 25
// x = 32; Somente x foi alterado
// Console.WriteLine(x); 32
// Console.WriteLine(y); 25

// Reference Types
// Definições
// Armazenam o endereço do objeto que contém os dados
// Não armazena os dados em si
// São armazenados em um local da memória chamado de Heap
// Ao assimilar uma variável
// Criará uma referencia
// Aponta para a mesma informação
// Não são independentes 
// Quando não mais utilizados são marcados para a exclusão
// Garbage Collector passa removendo todos eles
// Classes, Objects, Arrays

// Ex.

// var arr = new string[2];
// var [0] = "Item 1";
// var arr2 = arr; Não cria uma cópia

// Console.WriteLine(arr[0]);
// Console.WriteLine(arr2[0]);

// Altera as duas listas
// arr[0] = "Item Alterado";
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr2[0]);