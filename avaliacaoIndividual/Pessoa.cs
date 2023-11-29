namespace avaliacaoIndividual;

public class Pessoa{
    public string? Nome { get; set; }

    protected DateTime dataNascimento;
    public virtual DateTime DataNascimento { get{
            return dataNascimento;
        }
        set{
            if(value > DateTime.Now){
                throw new Exception("Data de nascimento deve ser anterior a data atual");
            }
            dataNascimento = value;
        } 
    }

    private string? cpf;

    public int Idade => DateTime.Now.Year - this.DataNascimento.Year;
    
    public string? getCPF(){
        return cpf;
    }

    public void setCPF(string cpf){
        if(cpf.Length != 11){
            throw new Exception("CPF deve ter 11 dígitos");
        }

        this.cpf = cpf;
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
