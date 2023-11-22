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



#endregion


#region LINQ with Array


#endregion


#region Tuples-Lambda-LINQ


#endregion