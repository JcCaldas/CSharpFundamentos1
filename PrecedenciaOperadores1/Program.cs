Console.WriteLine("## Precedência de operadores ##\n");

int x = 10 - 2 * 3;
int y = (10 - 2) * 3;


Console.WriteLine($"10 - 2 * 3 = {x}");
Console.WriteLine($"(10 - 2) * 3 = {y}\n");

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
bool c = !(9 != 8) && (5 >= 7 || 8 >= 6);

Console.WriteLine($"!(9 != 8) && 5 >= 7 || 8 >= 6 = {b}");
Console.WriteLine($"!(9 != 8) && (5 >= 7 || 8 >= 6) = {c}\n");

int a = 5, d = 6, e = 4;
int r = --a * d - ++e;

Console.WriteLine($"a = {a}");
Console.WriteLine($"d = {d}");
Console.WriteLine($"e = {e}");
Console.WriteLine($"--a * d - ++e = {r}");

 

Console.ReadKey();