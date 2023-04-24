using System.Text;

Console.WriteLine("Atribuindo valor a double, float e decimal");
Console.WriteLine();

double n1 = 1.234; //não preciso indicar nada
float n2 = 1.234f; //precisa colocar o 'f' na frente para indicar
decimal n3 = 1.234m; //precisa colocar o 'm' na frente para indicar
//Decimal é sempre ultilizado em instituição financeira

Console.WriteLine("Double: " + n1);
Console.WriteLine("Float: " + n2);
Console.WriteLine("Decimal: " + n3);

Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Comparando a precisão de float, double e decimal");
Console.WriteLine();

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine("Float: 1/3 = " + x);
Console.WriteLine("Double: 1/3 = " + y);
Console.WriteLine("Decimal: 1/3 = " + z);

Console.ReadLine();