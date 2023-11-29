using semana4.Exercicios;
public class ContaBancaria{
    public string? Nome { get; set; }
    public int NumeroConta { get; set; }

    private int saldo;
    public int Saldo {
        get {
            return saldo;
        }
        
        set {
            if(value >= 0){
                saldo = value;
            }else{
                throw new System.Exception("Saldo não pode ser negativo");
            }
        }
    }

}
