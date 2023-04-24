Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

Console.WriteLine("Strings");
string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine();
Console.WriteLine(nome);
Console.WriteLine(titulo);

//strings são IMUTÁVEIS, cada alteração aloca um espaço na memória
//Para trabalhar com mudança de sting, é melhor ultilizar o StringBuilder
string valor = "Isto é uma sting";
valor = "Isto é uma string alterada";

Console.WriteLine();
Console.WriteLine("Object");
Console.WriteLine();

//Uso quando não se sabe o valor que será adicionado
object nota = 10;
object valorDecimal = 8.55m;
object nomeObject = "Maria";
object ativa = true;
object letra = 'A';

Console.WriteLine("Object numero: " + nota);
Console.WriteLine("Object decimal: " + valorDecimal);
Console.WriteLine("Object string: " + nomeObject);
Console.WriteLine("Object boolean: " + ativa);
Console.WriteLine("Object char: " + letra);
Console.WriteLine();

Console.WriteLine("Dynamic");
Console.WriteLine();

//Usado quando precisa utilizar recursos das linguagens dinâmicas
dynamic notaD = 10;
dynamic valorDecimalD = 8.55m;
dynamic nomeObjectD = "Maria";
dynamic ativaD = true;
dynamic letraD = 'A';

Console.WriteLine("Dynamic numero: " + notaD);
Console.WriteLine("Dynamic decimal: " + valorDecimalD);
Console.WriteLine("Dynamic string: " + nomeObjectD);
Console.WriteLine("Dynamic boolean: " + ativaD);
Console.WriteLine("Dynamic char: " + letraD);
Console.WriteLine();

Console.ReadLine();