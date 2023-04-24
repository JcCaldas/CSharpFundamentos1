Console.WriteLine("## Operadores Relacionais ##\n");

int x = 10;
int y = 20;

Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de y {y}");

//Resultados semelhantes
Console.WriteLine($"x == y => {x == y}");

bool resultado = x == y;
Console.WriteLine($"x == y => {resultado}");

//Outros operadores relacionais
Console.WriteLine($"x > y => {x > y}");
Console.WriteLine($"x < y => {x < y}");
Console.WriteLine($"x >= y => {x >= y}");
Console.WriteLine($"x <= y => {x <= y}");
Console.WriteLine($"x != y => {x != y}");

//Com strings (somente o ==)

string a = "Curso";
string b = "curso";

Console.WriteLine($"\nValor de a {a}");
Console.WriteLine($"Valor de b {b}");

//Resultados semelhantes
Console.WriteLine($"a == b => {a == b}");

bool resultado2 = a == b;
Console.WriteLine($"a == b => {resultado2}");

Console.WriteLine($"a == b => {a.Equals(b)}");


Console.ReadKey();