Console.WriteLine("## Operadores Lógicos ##\n");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}.");
Console.WriteLine($"c2 = {c2}.\n");

//operador AND -> &&
Console.WriteLine("Operador AND (&&)");
resultado = c1 && c2;
Console.WriteLine($"c1 && c2 = {resultado}\n");

//operador OR -> ||
Console.WriteLine("Operador OR (||)");
resultado = c1 || c2;
Console.WriteLine($"c1 || c2 = {resultado}\n");

//operador NOT -> |
Console.WriteLine("Operador NOT (!)");
resultado = !c1;
Console.WriteLine($"!c1 = {resultado}\n");

Console.ReadKey();