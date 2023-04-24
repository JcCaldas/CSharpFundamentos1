using System.Drawing;

Console.WriteLine("## Operadores de atribuição ##\n");

//usando operadores com tipos numéricos
var x = 10;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x+=5 ==> {x += 5}");
Console.WriteLine($"x-=3 ==> {x -= 3}");
Console.WriteLine($"x*=4 ==> {x *= 4}");
Console.WriteLine($"x/=5 ==> {x /= 5}");
Console.WriteLine($"x%=5 ==> {x %= 5}");

//usando operadores + e += com strings

var y = "123";
Console.WriteLine($"\nValor inicial de y = {y}");
Console.WriteLine($"y+=\"456\" ==> {y += "456"}");

Console.ReadKey();