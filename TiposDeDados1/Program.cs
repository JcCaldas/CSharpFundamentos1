Console.WriteLine("Declarando variáveis numéricas");
Console.WriteLine();
//declarações de variaveis
sbyte valorSbyte = -127;
byte valorByte = 255;
short valorShort = -32767;
ushort valorUShort = 65535;
int valorInt = -2147483647;
uint valorUint = 4294967295;
long valorLong = -9223372036854775807;
ulong valorULong = 18446744073709511615;

//Pode-se declarar variáveis na mesma linha, desde que sejam do mesmo tipo

int valor1 = 8, valor2 = 7, valor3 = 9;

//Variaveis podem receber um novo valor, const não.

const int valorConst = 255;

Console.WriteLine("Variáveis");
Console.WriteLine("sbyte: " + valorSbyte);
Console.WriteLine("byte: " + valorByte);
Console.WriteLine("short: " +  valorShort);
Console.WriteLine("UShort: " + valorUShort);
Console.WriteLine("int: " + valorInt);
Console.WriteLine("UInt: " + valorUint);
Console.WriteLine("long: " + valorLong);
Console.WriteLine("ulong: " + valorULong);
Console.WriteLine();
Console.WriteLine("Variaveis na mesma linha");
Console.WriteLine("valor1: " + valor1);
Console.WriteLine("valor2: " + valor2);
Console.WriteLine("valor3: " + valor3);
Console.WriteLine();
Console.WriteLine("Constante");
Console.WriteLine("Valor Constante: " + valorConst);

Console.ReadKey();
