// Conversão Implícita
// Definições 
// É comum precisarmos transformar um dado de tipo x para tipo y
// Existem dois tipos de conversão, as implictas e as explicitas
// As implicitas são conversões que podem ser executadas apenas com passagem de dados
// Possuem tipos compatíveis

// float valor = 25.8F;
// int outro = 25;
// valor = outro conversão implícita

// A conversão anterior ocorreu pois um número real pode receber um número inteiro
// Porém, ao contrário não aconteceria
// Um número inteiro não tem pontuação
// Logo ele não poderia receber um número real
// A conversão só ocorrerá se o tipo de dado for compatível
// Em caso de números a precisão pode ser alterada
// Qualquer situação adversa causará erro

// sbyte - short, int, long, float, double, decimal
// byte - short, ushort, int, uint, long, ulong, float, double, decimal
// short - int, long, float, double, or decimal
// ushort - int, uint, long, float, double, or decimal
// int - long, float, double, or decimal

// uint - long, ulong, float, double, or decimal
// long - float, double, or decimal
// ulong - float, double, or decimal
// char - ushort, int, uint, long, ulong, float, double, or decimal
// float - double 