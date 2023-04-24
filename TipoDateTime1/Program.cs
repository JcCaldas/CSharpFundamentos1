Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine();

//criar data específica usa formato:aaaa,mm,dd
//hora, minuto e segundo ficam zerados
DateTime dataEspecifica = new DateTime(1983, 12, 29);
Console.WriteLine("Data específica: " + dataEspecifica);
Console.WriteLine();

//especificando hora, min, seg
DateTime dataEspecifica2 = new DateTime(1983, 12, 29, 15,30,32);
Console.WriteLine("Data específica com hora especificada: " + dataEspecifica2);
Console.WriteLine();

//extrair informações da data atual
Console.WriteLine("Extraindo informações da Data");
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine("Data atual Ano: " + dataAtual.Year);
Console.WriteLine("Data atual Mês: " + dataAtual.Month);
Console.WriteLine("Data atual Dia: " + dataAtual.Day);
Console.WriteLine("Data atual Hora: " + dataAtual.Hour);
Console.WriteLine("Data atual Minutos: " + dataAtual.Minute);
Console.WriteLine("Data atual Segundos: " + dataAtual.Second);
Console.WriteLine("Data atual Milisegundos: " + dataAtual.Millisecond);
Console.WriteLine();

//adicionando valores a data atual
Console.WriteLine("Adicionando valores a Data");
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine("Data atual Add 30 Anos: " + dataAtual.AddYears(30));
Console.WriteLine("Data atual Add 3 Mêses: " + dataAtual.AddMonths(3));
Console.WriteLine("Data atual Add 15 Dias: " + dataAtual.AddDays(15));
Console.WriteLine("Data atual Add 2 Horas: " + dataAtual.AddHours(2));
Console.WriteLine();

//obter o dia da semana
Console.WriteLine("Obter dia da semana");
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine("Data atual exibindo dia da semana: " + dataAtual.DayOfWeek);
Console.WriteLine("Data atual exibindo dia do ano: " + dataAtual.DayOfYear);
Console.WriteLine();

//Data no formato longo e curto (métodos)
Console.WriteLine("Data no formato longo e curto");
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine("Data atual exibindo data no formato longo: " + dataAtual.ToLongDateString());
Console.WriteLine("Data atual exibindo data no formato curto: " + dataAtual.ToShortDateString());
Console.WriteLine("Data atual exibindo hora no formato longo: " + dataAtual.ToLongTimeString());
Console.WriteLine("Data atual exibindo hora no formato curto: " + dataAtual.ToShortTimeString());
Console.WriteLine();


Console.ReadLine();