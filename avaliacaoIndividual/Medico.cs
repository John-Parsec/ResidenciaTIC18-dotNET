using avaliacaoIndividual;
public class Medico : Pessoa{

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
