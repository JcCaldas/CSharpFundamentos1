Console.WriteLine("## Operadores Incremento e Decremento ##\n");

//pós incremento "x++" -> primeiro resolve e depois incrementa
int x = 0;
Console.WriteLine($"x = {x}");

int resultado1 = x++ + 10;
Console.WriteLine($"Resultado pós incremento = {resultado1}");
Console.WriteLine($"valor de x = {x}");

//pré incremento "++x" -> primeiro incrementa e depois resolve
int y = 0;
Console.WriteLine($"\ny = {y}");

int resultado2 = ++y + 10;
Console.WriteLine($"Resultado pós incremento = {resultado2}");
Console.WriteLine($"valor de y = {y}");

//pós decremento "x--" -> primeiro resolve e depois decrementa
int z = 0;
Console.WriteLine($"\nz = {z}");

int resultado3 = z-- + 10;
Console.WriteLine($"Resultado pós decremento = {resultado3}");
Console.WriteLine($"valor de z = {z}");

//pré decremento "++x" -> primeiro decrementa e depois resolve
int a = 0;
Console.WriteLine($"\na = {a}");

int resultado4 = --a + 10;
Console.WriteLine($"Resultado pós decremento = {resultado4}");
Console.WriteLine($"valor de a = {a}");

Console.ReadKey();