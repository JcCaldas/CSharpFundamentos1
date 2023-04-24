Console.WriteLine("## Inferência Tipos (var) ##\n");

//define explicitamente as variaveis (jeito "normal")
int idade = 25;
string nome = "Maria";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");//"c" -> formata para a moeda local

//define implicitamente ultilizando a palavra "var" o compilador entende qual é o tipo de variavel e define ela.
var idade2 = 25;
var nome2 = "Maria";
var salario2 = 2500.00m;

Console.WriteLine($"{nome2} tem {idade2} anos e ganha {salario2.ToString("c")}");//"c" -> formata para a moeda local


//var: limitações
var salario3 = null; //Não pode ser inicializa com null
var titulo; //Tem q ser inicializada
var imposto, total, nota; //não pode inicializar mais de uma var por linha

//não pode mudar o tipo após inicializar
var num = 10;
num = 20;
num = "teste";



Console.ReadKey();