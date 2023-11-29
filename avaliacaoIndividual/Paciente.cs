using avaliacaoIndividual;
public class Paciente : Pessoa{
    private string? sexo;

    public string? Sexo {
        get{
            return sexo;
        } 
        set{
            try{
                if(value != "masculino" && value != "feminino"){
                    throw new System.Exception("Sexo deve ser Masculino ou Feminino");
                }
                sexo = value;
            }catch(System.Exception e){
                Console.WriteLine(e.Message);
            }
        } 
    }
    List<string> Sintomas { get; }

    public Paciente(string nome, DateTime dataNascimento, string cpf, string sexo) : base(nome, dataNascimento, cpf){
        try{
            this.Sexo = sexo;
        }catch(System.Exception e){
            Console.WriteLine(e.Message);
        }

        this.Sintomas  = new List<string>();
    }

    public Paciente(string nome, string dataNascimento, string cpf, string sexo) : base(nome, dataNascimento, cpf){
        try{
            this.Sexo = sexo;
        }catch(System.Exception e){
            Console.WriteLine(e.Message);
        }

        this.Sintomas  = new List<string>();
    }

    public void addSintoma(string sintoma){
        this.Sintomas.Add(sintoma);
    }


}
