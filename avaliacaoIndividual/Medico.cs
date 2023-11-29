using avaliacaoIndividual;
public class Medico : Pessoa{

    public override DateTime DataNascimento { get{
            return dataNascimento;
        }
        set{
            if(value > DateTime.Now.AddYears(-18)){
                throw new System.Exception("Médico deve ter no mínimo 18 anos");
            }
            dataNascimento = value;
        } 
    }

    public string? CRM { get; set; }

    public Medico(string nome, DateTime dataNascimento, string cpf, string crm) : base(nome, dataNascimento, cpf){
        this.CRM = crm;
    }

    public Medico(string nome, string dataNascimento, string cpf, string crm) : base(nome, dataNascimento, cpf){
        this.CRM = crm;
    }

    public Medico() : base(){
        this.CRM = "";
    }

}
