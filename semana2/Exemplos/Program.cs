#region Foreach example

string[] colecao = {"item1", "item2", "item3", "item4", "item5"};

foreach (string item in colecao)
{
    Console.WriteLine(item);
}

#endregion


#region ReadLine example

Console.WriteLine("Digite seu nome:");
string? nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");

#endregion