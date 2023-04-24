Console.WriteLine("Atribuindo valores para bool e char");

bool ativo = true;
Boolean inativo = false;

Console.WriteLine("Ativo: " + ativo);
Console.WriteLine("Inativo: " + inativo);

//Pode ser recebido em expressões de comparação

Console.WriteLine("10 == 15 = " + (10 == 15));//resultado false
Console.WriteLine("10 == 10 = " + (10 == 10));//resultado true
Console.WriteLine();

char letra1 = 'A';//Deve-se declarar dentro de aspas simples, pois tudo que está dentro de aspas duplas é considerado string
char letra2 = '\u0041';// \u indica que é o caracter unicode

Console.WriteLine("Char 'A' declarado normal: " + letra1);
Console.WriteLine("Char 'A' declarado Unicode (0041): " + letra2);


Console.ReadLine();