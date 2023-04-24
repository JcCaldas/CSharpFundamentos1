Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomecompleto;
int idade;
int _valor;
int idade1;

/*
 Identificadores inválidos
int 5idade;
int $valor;
int valor#total;
string nome Completo;
 */

//para nomes de variáveis: Camel Case (camelCase)
string descontoTotal;
string desconto_Total;

//para constantes: MAIÚSCULAS
const double PI = 3.14;
const string PREFIXO = "27";
const string PREFIXO_ES = "27";


//para nomes de classes e métodos: Pascal Case (PascalCase)
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Jessé");
    }
}


Console.ReadLine();