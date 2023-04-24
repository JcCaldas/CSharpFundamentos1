Console.WriteLine("## Operador Uniário e Ternário ##\n");


Console.WriteLine("Operador Uniário");

//O positivo somente retorna o número, mesmo ele sendo negativo

Console.WriteLine("Informe o número: \n");
var n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{

    Console.WriteLine($"O negativo de {n} é {-n}\n");

}
else
{

    Console.WriteLine($"O positivo de {n} é {n*-1}\n");

}

Console.WriteLine("Operador Ternário\n");

Console.WriteLine("Informe a temperatura: \n");
var temp = Convert.ToInt32(Console.ReadLine());

var resultado = temp > 27 ? "quente" :
    temp >= 20 && temp <= 27 ? "normal" :
    temp <20 ? "frio": "Sem resultado";

Console.WriteLine($"O dia está {resultado}");


Console.ReadKey();