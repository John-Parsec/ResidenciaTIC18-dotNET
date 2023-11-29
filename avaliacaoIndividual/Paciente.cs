using avaliacaoIndividual;
public class Paciente : Pessoa{

    public string Sexo {
        get{
            return Sexo;
        } 
        set{
            try{
                if(value != "Masculino" && value != "Feminino"){
                    throw new System.Exception("Sexo deve ser Masculino ou Feminino");
                }
                Sexo = value;
            }catch(System.Exception e){
                Console.WriteLine(e.Message);
            }
        } 
    }
    List<string> Sintomas { get; }

    public Paciente(string nome, DateTime dataNascimento, string cpf, string sexo) : base(nome, dataNascimento, cpf){
        this.Sexo = sexo;
        this.Sintomas  = new List<string>();
    }

    public Paciente(string nome, string dataNascimento, string cpf, string sexo) : base(nome, dataNascimento, cpf){
        this.Sexo = sexo;
        this.Sintomas  = new List<string>();
    }

    public Paciente(){
        this.Sexo = "";
        this.Sintomas  = new List<string>();
    }

    public void addSintoma(string sintoma){
        this.Sintomas.Add(sintoma);
    }


}
