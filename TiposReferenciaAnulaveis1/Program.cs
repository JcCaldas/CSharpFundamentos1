Console.WriteLine("## Tipos de referência Anuláveis ##\n");

string? nome = null;
string nome2 = "";

Console.WriteLine(nome?.ToUpper());
Console.WriteLine(nome2?.ToUpper());

Console.ReadKey();