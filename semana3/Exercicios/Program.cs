#region Tuples

Func<string, int, (string, int)> toTuple = (string nome, int idade) => (nome, idade);

Console.WriteLine($"Tupla: {toTuple("John", 23)}");
Console.WriteLine($"Tupla: {toTuple("Teste", 0)}");

#endregion


#region Lambda
Func<int, int, int> somaQuadrado = (x, y) => (x * x) + (y * y);

Console.WriteLine($"Soma dos quadrados: {somaQuadrado(2, 3)}");
Console.WriteLine($"Soma dos quadrados: {somaQuadrado(5, 5)}");

#endregion


#region LINQ with List

List<(string, int)> pessoas = new List<(string, int)>();
pessoas.Add(("John", 23));
pessoas.Add(("Mary", 25));
pessoas.Add(("Peter", 31));
pessoas.Add(("Paul", 35));

var maior30 = pessoas.Where(p => p.Item2 > 30);

Console.WriteLine($"Pessoas com mais de 30 anos: {maior30}");

#endregion


#region LINQ with Array


#endregion


#region Tuples-Lambda-LINQ


#endregion


#region Try Catch Finally

int num;

Console.Write("Digite um número: ");

try{
    num = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Número digitado: {num}");
}
catch(FormatException e){
    Console.WriteLine($"Erro: {e.Message}");
}


Console.WriteLine("\n");


Func<float, float, float> divisao = (x, y) => x / y;

Console.Write("Digite o primeiro número: ");
float num1 = float.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
float num2 = float.Parse(Console.ReadLine()!);

try{
    Console.WriteLine($"Resultado: {divisao(num1, num2)}");
}
catch(DivideByZeroException e){
    Console.WriteLine($"Erro: {e.Message}");
}
finally{
    Console.WriteLine("Fim do programa");
}


Console.WriteLine("\n");


int fatorial(int n){
    if(n < 0)
        throw new Exception("Número negativo");
    else{
        if(n == 0 || n == 1)
            return 1;
        else
            return n * fatorial(n - 1);
    }
}

try{
    Console.Write("Digite um número: ");
    int num3 = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Fatorial de {num3}: {fatorial(num3)}");
}
catch(Exception e){
    Console.WriteLine($"Erro: {e.Message}");
}
finally{
    Console.WriteLine("Fim do programa");
}


Console.WriteLine("\n");


Console.Write("Digite o caminho do arquivo: ");
string path = Console.ReadLine()!;

try{
    string[] lines = File.ReadAllLines(path);

    foreach(string line in lines)
        Console.WriteLine(line);
}
catch(IOException e){
    Console.WriteLine($"Erro: {e.Message}");
}
finally{
    Console.WriteLine("\n");
}
#endregion