Console.WriteLine("Conversão de tipos 2\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;
bool valorBoolean = true;

//Converte numericos em strings
string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();
string s4 = valorBoolean.ToString();

//Conversão utilizando a classe Convert

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDecimal(valorDouble));
Console.WriteLine(Convert.ToUInt32(valorDecimal));
Console.WriteLine(Convert.ToString(valorBoolean));




Console.ReadLine();