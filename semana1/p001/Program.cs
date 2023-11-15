// 2.
// Os tipos de dados numéricos inteiros disponíveis no .NET são:
// sbyte, byte, short, ushort, int, uint, long, ulong
// Exemplos de uso:

sbyte sb = sbyte.MinValue;

byte by = byte.MaxValue;

short s = short.MinValue;

ushort us = ushort.MaxValue;

int i = 1000;

uint ui = 1000U;

long l = 1000L;

ulong ul = 1000UL;

//3
double d = 10.5;
int z = (int)d;
//A parte fracionária será descartada, resultando em z = 10

//4
int x = 10;
int y = 3;

Console.WriteLine(x + y);
Console.WriteLine(x - y);
Console.WriteLine(x * y);
Console.WriteLine(x / y);

//5
int a = 5;
int b = 8;

if (a > b){
    Console.WriteLine("a é maior que b");
}
else{
    Console.WriteLine("a não é maior que b");
}

//6
string str1 = "Hello";
string str2 = "World";

Console.WriteLine(str1 == str2);

//7
bool condicao1 = true;
bool condicao2 = false;

if (condicao1 && condicao2){
    Console.WriteLine("Ambas as condições são verdadeiras");
}
else{
    Console.WriteLine("Ambas as condições não são verdadeiras");
}

//8
int num1 = 7;
int num2 = 3;
int num3 = 10;

if (num1 > num2 && num3 == (num1 + num2)){
    Console.WriteLine("num1 é maior que num2 e num3 é igual a num1 + num2");
}
else{
    Console.WriteLine("num1 não é maior que num2 e num3 não é igual a num1 + num2");
}