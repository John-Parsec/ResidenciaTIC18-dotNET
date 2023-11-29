namespace avaliacaoIndividual;

public class Pessoa{
    public string? Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    private string? cpf;

    public int Idade => DateTime.Now.Year - this.DataNascimento.Year;
    
    public string? getCPF(){
        return cpf;
    }

    public void setCPF(string cpf){
        try{
            if(cpf.Length != 11){
                throw new Exception("CPF deve ter 11 dígitos");
            }

            this.cpf = cpf;
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public Pessoa(){
        this.Nome = "";
        this.DataNascimento = DateTime.MinValue;
        this.cpf = "";
    }
    
    public Pessoa(string nome, DateTime dataNascimento, string cpf){
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
        this.setCPF(cpf);
    }

    public Pessoa(string nome, string dataNascimento, string cpf){
        this.Nome = nome;
        this.DataNascimento = DateTime.Parse(dataNascimento);
        this.setCPF(cpf);
    }

}
