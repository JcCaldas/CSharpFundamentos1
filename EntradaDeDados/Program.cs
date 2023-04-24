Console.WriteLine("## Entrada de dados ##\n");

Console.WriteLine("Informe o se nome: ");
string nome =  Console.ReadLine();

Console.WriteLine("Informe a sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nOlá {nome}! A sua idade é {idade} anos.");

Console.ReadKey();