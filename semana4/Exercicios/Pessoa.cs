namespace semana4.Exercicios;
public class Pessoa{
    public Pessoa(string nome, float altura){
        this.nome = nome;
        this.altura = altura;
    }

    public string nome { get; private set; }
    public float altura { get; private set; }
}
