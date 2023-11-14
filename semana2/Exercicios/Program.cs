int i;
int j;

#region Exercicio1

Console.WriteLine("Multiplos de 3 e 4: ");

for(i = 0; i <= 30; i++){
    if(i % 3 == 0 || i % 4 == 0){
        Console.WriteLine(i);
    }
}

#endregion


#region Exercicio2

int[] fib = new int[30];

fib[0] = 0;
fib[1] = 1;

for(i = 2; fib[i-1] <= 100; i++){
    fib[i] = fib[i-1] + fib[i-2];
}

Console.WriteLine("\n\nFibonacci: ");

for(j = 0; j < i ; j++){
    Console.WriteLine(fib[j]);
}

#endregion


#region Exercicio3

Console.WriteLine("\n\nTriangulo: ");
for(i = 1; i <= 8; i++){
    for(j = 1; j <= i; j++){
        Console.Write($"{i*j} ");
    }
    Console.WriteLine();
}

#endregion