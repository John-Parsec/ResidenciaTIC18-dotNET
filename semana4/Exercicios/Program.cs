using semana4.Exercicios;

Func<Pessoa, Pessoa, float> mediaAltura = (p1, p2) => (p1.altura + p2.altura) / 2;

List<Pessoa> pessoas = new List<Pessoa>();

pessoas.Add(new Pessoa("João", 1.75f));
pessoas.Add(new Pessoa("Maria", 1.65f));

Console.WriteLine($"A média de altura entre {pessoas[0].nome} e {pessoas[1].nome} é {mediaAltura(pessoas[0], pessoas[1])}m");