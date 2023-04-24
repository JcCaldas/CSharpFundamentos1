using System.Runtime.InteropServices;

Console.WriteLine("## Nullable Types ##\n");

/*Os Nullable vão suportar todos os valores deles
 mais o null*/

//Sintaxe padrão
//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

//Sintaxe simplificada
int? i = null;
double? d = null;
bool? b = null;

Console.WriteLine("Nullable Int: " + i);
Console.WriteLine("Nullable Double: " + d);
Console.WriteLine("Nullable bool: " + b);
Console.WriteLine("Não aparece nada, pois o 'null' não retorna nada");
Console.WriteLine();

//Coalescência nula (??)
/*Se o valor for nulo, ele retorna o outro indicado
 caso não seja nulo, ele retorna o valor referente*/

int? a = null;
int c = a ?? 10;

Console.WriteLine("Coalescência nula");
Console.WriteLine("int a = null");
Console.WriteLine("int c = " + c);
Console.WriteLine();

a = 15;
c = a ?? 10;

Console.WriteLine("int a = 15");
Console.WriteLine("int c = " + c);
Console.WriteLine();


//Nullable typo em expressões
/*Todos precisam estar definidos como nullabe types*/

int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine("Nullable typo em expressões");
Console.WriteLine($"3 / 4 = {z}");
Console.WriteLine();

//Propriedades somente leitura: HasValue e Value

Console.WriteLine("Propriedades somente leitura: HasValue e Value");
Console.WriteLine("e = null");
int? e = null;

if (e.HasValue)
{
    Console.WriteLine($"e = {e.Value}");
}
else
{
    Console.WriteLine("e não possui um valor");
}


Console.WriteLine("e = 100");
e = 100;

if (e.HasValue)
{
    Console.WriteLine($"e = {e.Value}");
}
else
{
    Console.WriteLine("e não possui um valor");
}



Console.ReadLine();