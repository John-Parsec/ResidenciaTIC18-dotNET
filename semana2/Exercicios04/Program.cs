#region Exercicio1

Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Exercicio 1\n");

string data = "25/10/2023";

string[] dataSplit = data.Split('/');

Console.WriteLine($"Dia: {dataSplit[0]}");
Console.WriteLine($"Mês: {dataSplit[1]}");
Console.WriteLine($"Ano: {dataSplit[2]}");

#endregion


#region Exercicio2

Console.WriteLine("\n---------------------------------------------------");
Console.WriteLine("Exercicio 2\n");

int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

foreach(int num in numeros){
    if(num % 2 == 0)
        Console.WriteLine(num);
}

#endregion


#region Exercicio3

Console.WriteLine("\n---------------------------------------------------");
Console.WriteLine("Exercicio 3\n");

List<string> cidades = new List<string>();

cidades.Add("Ilhéus");
cidades.Add("Itabuna");
cidades.Add("Una");
cidades.Add("Itacaré");
cidades.Add("Salvador");

foreach(string cidade in cidades){
    if(cidade.StartsWith("S"))
        Console.WriteLine(cidade);
}

#endregion


#region Exercicio4

Console.WriteLine("\n---------------------------------------------------");
Console.WriteLine("Exercicio 4\n");

DateTime dataAtual = DateTime.Today;
DateTime dataFuturo = new DateTime(2025, 10, 25);

Console.WriteLine($"Data atual: {dataAtual.ToShortDateString()}");
Console.WriteLine($"Data futuro: {dataFuturo.ToShortDateString()}");

TimeSpan diferenca = dataFuturo - dataAtual;
Console.WriteLine($"Diferença: {diferenca.TotalMinutes}");

#endregion