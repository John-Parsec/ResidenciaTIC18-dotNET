using avaliacaoIndividual;
public class Consultorio{
    public List<Medico> Medicos { get; }
    public List<Paciente> Pacientes { get; }

    public Consultorio(){
        this.Medicos = new List<Medico>();
        this.Pacientes = new List<Paciente>();
    }

    public void addMedico(Medico medico){
        try{
            for (int i = 0; i < this.Medicos.Count; i++){
                if(this.Medicos[i].getCPF() == medico.getCPF() || this.Medicos[i].CRM == medico.CRM){
                    throw new System.Exception("Este medico já está cadastrado");
                }
            }

            this.Medicos.Add(medico);
        }catch(System.Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public void addPaciente(Paciente paciente){
        try{
            for (int i = 0; i < this.Pacientes.Count; i++){
                if(this.Pacientes[i].getCPF() == paciente.getCPF()){
                    throw new System.Exception("Este paciente já está cadastrado");
                }
            }

            this.Pacientes.Add(paciente);
        }catch(System.Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public void medicosIdadeEntre(int min, int max){
        List<Medico> medicos = new List<Medico>();

        medicos = this.Medicos.FindAll(m => m.Idade >= min && m.Idade <= max);

        Console.WriteLine($"Médicos entre {min} e {max} anos:");
        foreach (Medico m in medicos){
            Console.WriteLine($"Nome: {m.Nome} | Data de Nascimento: {m.DataNascimento} | CPF: {m.getCPF()} | CRM: {m.CRM}");
        }
    }
    public void pacientesIdadeEntre(int min, int max){
        List<Paciente> pacientes = new List<Paciente>();

        pacientes = this.Pacientes.FindAll(p => p.Idade >= min && p.Idade <= max);

        Console.WriteLine($"Pacientes entre {min} e {max} anos:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }

    public void pacientesPorSexo(string sexo){
        List<Paciente> pacientes = new List<Paciente>();

        pacientes = this.Pacientes.FindAll(p => p.Sexo == sexo.ToLower());

        Console.WriteLine($"Pacientes do sexo {sexo}:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }

    public void pacientesOrdemAlfabetica(){
        List<Paciente> pacientes = new List<Paciente>();

        pacientes = this.Pacientes.OrderBy(p => p.Nome).ToList();

        Console.WriteLine($"Pacientes em ordem alfabética:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }

    public void pacientesComSintoma(string sintoma){
        List<Paciente> pacientes = new List<Paciente>();

        pacientes = this.Pacientes.FindAll(p => p.Sintomas.Contains(sintoma));

        Console.WriteLine($"Pacientes com o sintoma {sintoma}:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }

    public void aniversariantesDoMes(){
        List<Paciente> pacientes = new List<Paciente>();
        List<Medico> medicos = new List<Medico>();

        pacientes = this.Pacientes.FindAll(p => p.DataNascimento.Month == DateTime.Now.Month);
        medicos = this.Medicos.FindAll(m => m.DataNascimento.Month == DateTime.Now.Month);

        Console.WriteLine($"Médicos aniversariantes do mês:");
        foreach (Medico m in medicos){
            Console.WriteLine($"Nome: {m.Nome} | Data de Nascimento: {m.DataNascimento} | CPF: {m.getCPF()} | CRM: {m.CRM}");
        }

        Console.WriteLine($"Pacientes aniversariantes do mês:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }
}
