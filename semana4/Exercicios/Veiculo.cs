using semana4.Exercicios;
public class Veiculo{
    public string? Modelo { get; set; }
    public int Ano { get; set; }
    public string? Cor { get; set; }
    public string? Placa { get; set; }

    public int IdadeVeiculo => DateTime.Now.Year - Ano;
}
