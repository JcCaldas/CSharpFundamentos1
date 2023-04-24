Console.WriteLine("## Operadores Aritméticos ##");

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A soma de x + y = {x+y}");
Console.WriteLine($"A subtração de x - y = {x-y}");
Console.WriteLine($"A multiplicação de x * y = {x*y}");
Console.WriteLine($"A divisão de x / y = {Convert.ToDecimal((decimal) x/y)}");
Console.WriteLine($"O módulo (resto da divisão) de x % y = {x%y}");

Console.WriteLine("\nClasse Math\n");
Console.WriteLine($"Raiz quadrada x = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"Valor mínimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"Valor máximo entre x e y = {Math.Max(x,y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno de x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");




Console.ReadKey();