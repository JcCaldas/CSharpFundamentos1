Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

string nome = "Maria";
int idade = 25;

//Console.WriteLine(); - escreve na linha e pula para próxima
Console.WriteLine("WriteLine escreve na linha e pula para a outra");
Console.WriteLine($"O nome é {nome}.");
Console.WriteLine($"A idade é {idade}.");


//Console.Write(); - escreve na linha e permanece nela
Console.Write($"O nome é {nome}.");
Console.Write($"A idade é {idade}.");

//Concatenação
Console.WriteLine(nome + " tem " + idade + " anos");

//MAIS USADO!!!!!!!!!!!!
//Interpolação de strings: $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos.");

//place holders: usa {} com numeração com inicio em zero]
Console.WriteLine("{0} tem {1} anos.", nome, idade);

Console.ReadLine();