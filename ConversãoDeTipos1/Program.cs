Console.WriteLine("## Conversão de tipos ##\n");

/*
Conversões implicitas

Conversão de variaveis de tamanho menor (bytes) para maior
é feita de forma implicita (automáticamente). Mas ao contrário não.
byte -> 1 byte
short ->2 bytes
int -> 4 bytes
long -> 8 bytes
float -> 4 bytes
decimal -> 16bytes

 */
Console.WriteLine("Exemplo de conversão implicita:");
int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine("Int: " + numeroInt);
Console.WriteLine("Long: " + numeroLong);
Console.WriteLine("Float: " + numeroFloat);
Console.WriteLine("Double: " + numeroDouble);
Console.WriteLine("Decimal: " + numeroDecimal + "\n");

/*
Conversão explicita
 
Nesse tipo de conversão deve-se indicar que ela ocorre,
Existe a perda de precisão (ex: casas decimais)
*/
Console.WriteLine("Exemplo conversão explicita:");
double varDouble = 12.456; //8 bytes
//Deve-se fazer um cast, indicando qual tipo a variavel vai se tornar (colocando entre parenteses)
int varInt = (int)varDouble; //4 bytes (perda de precisão - casas decimais)
Console.WriteLine($"Double: {varDouble}\nInt: {varInt}");

int num1 = 10;
int num2 = 4;

float resultado = num1 / num2; //10/4 = 2.5 - mas nesse caso não haverá casa decimal, por se tratar de duas variaveis do tipo int
float resultadoConvertido = (float) num1 / num2; //conversão das variaveis de int para float e depois ocorre a divisão

Console.WriteLine($"Sem conversão: {num1} / {num2} = {resultado}");
Console.WriteLine($"Com conversão: {num1} / {num2} = {resultadoConvertido}");


Console.ReadLine();