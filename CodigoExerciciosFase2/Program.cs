using System.ComponentModel.DataAnnotations;

Console.WriteLine("Formula de Báscara\n");

int a = 1, b= 12, c = -13;
double delta, x1, x2;

delta = Math.Pow(b, 2) - 4 * a * c;
x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;
Console.WriteLine($"X1 = {x1}");
Console.WriteLine($"X2 = {x2}\n");

Console.WriteLine("Usuario e senha");

string nome, resultado;
int senha;

Console.WriteLine("Digite o login:");
nome = Console.ReadLine();

Console.WriteLine("Digite a senha:");
senha = Convert.ToInt32(Console.ReadLine());

resultado = (nome == "maria" || nome == "admin") && senha == 123 ? "\nLogin feito com sucesso" : "\nLogin Inválido" ;

Console.WriteLine(resultado);

Console.WriteLine($"Login: {nome}");
Console.WriteLine($"Senha: {senha}");


Console.ReadKey();