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

        pacientes = this.Pacientes.FindAll(p => p.Sintomas.Contains(sintoma.ToLower()));

        Console.WriteLine($"Pacientes com o sintoma {sintoma}:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }

    public void aniversariantesDoMes(int mes){
        if(mes < 1 || mes > 12){
            throw new System.Exception("Mês inválido");
        }

        List<Paciente> pacientes = new List<Paciente>();
        List<Medico> medicos = new List<Medico>();

        pacientes = this.Pacientes.FindAll(p => p.DataNascimento.Month == mes);
        medicos = this.Medicos.FindAll(m => m.DataNascimento.Month == mes);

        Console.WriteLine($"Médicos aniversariantes do mês {mes}:");
        foreach (Medico m in medicos){
            Console.WriteLine($"Nome: {m.Nome} | Data de Nascimento: {m.DataNascimento} | CPF: {m.getCPF()} | CRM: {m.CRM}");
        }

        Console.WriteLine($"Pacientes aniversariantes do mês {mes}:");
        foreach (Paciente p in pacientes){
            Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
        }
    }


    public void menu(){
        int opcao;

        do{
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Cadastrar Médico");
            Console.WriteLine("2 - Cadastrar Paciente");
            Console.WriteLine("3 - Listar Médicos");
            Console.WriteLine("4 - Listar Pacientes");
            Console.WriteLine("5 - Médicos entre idades");
            Console.WriteLine("6 - Pacientes entre idades");
            Console.WriteLine("7 - Pacientes pelo sexo");
            Console.WriteLine("8 - Pacientes em ordem alfabética");
            Console.WriteLine("9 - Pacientes pelo sintoma");
            Console.WriteLine("10 - Aniversariantes do mês");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite uma opção: ");
            opcao = int.Parse(Console.ReadLine()!);

            switch(opcao){
                case 1:
                    try{
                        Console.Write("Digite o nome do médico: ");
                        string nomeMedico = Console.ReadLine()!;

                        Console.Write("Digite a data de nascimento do médico: ");
                        DateTime dataNascimentoMedico = DateTime.Parse(Console.ReadLine()!);

                        Console.Write("Digite o CPF do médico: ");
                        string cpfMedico = Console.ReadLine()!;

                        Console.Write("Digite o CRM do médico: ");
                        string crmMedico = Console.ReadLine()!;

                        Medico medico = new Medico(nomeMedico, dataNascimentoMedico, cpfMedico, crmMedico);

                        this.addMedico(medico);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 2:
                    try{
                        Console.Write("Digite o nome do paciente: ");
                        string nomePaciente = Console.ReadLine()!;

                        Console.Write("Digite a data de nascimento do paciente: ");
                        DateTime dataNascimentoPaciente = DateTime.Parse(Console.ReadLine()!);

                        Console.Write("Digite o CPF do paciente: ");
                        string cpfPaciente = Console.ReadLine()!;

                        Console.Write("Digite o sexo do paciente: ");
                        string sexoPaciente = Console.ReadLine()!;

                        Paciente paciente = new Paciente(nomePaciente, dataNascimentoPaciente, cpfPaciente, sexoPaciente);

                        this.addPaciente(paciente);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                
                case 3:
                    Console.WriteLine("Médicos:");
                    foreach (Medico m in this.Medicos){
                        Console.WriteLine($"Nome: {m.Nome} | Data de Nascimento: {m.DataNascimento} | CPF: {m.getCPF()} | CRM: {m.CRM}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Pacientes:");
                    foreach (Paciente p in this.Pacientes){
                        Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
                    }
                    break;
                
                case 5:
                    try{
                        Console.Write("Digite a idade mínima: ");
                        int min = int.Parse(Console.ReadLine()!);

                        Console.Write("Digite a idade máxima: ");
                        int max = int.Parse(Console.ReadLine()!);

                        this.medicosIdadeEntre(min, max);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                
                case 6:
                    try{
                        Console.Write("Digite a idade mínima: ");
                        int min = int.Parse(Console.ReadLine()!);

                        Console.Write("Digite a idade máxima: ");
                        int max = int.Parse(Console.ReadLine()!);

                        this.pacientesIdadeEntre(min, max);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 7:
                    try{
                        Console.Write("Digite o sexo: ");
                        string sexo = Console.ReadLine()!;

                        this.pacientesPorSexo(sexo);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 8:
                    this.pacientesOrdemAlfabetica();
                    break;

                case 9:
                    try{
                        Console.Write("Digite o sintoma: ");
                        string sintoma = Console.ReadLine()!;

                        this.pacientesComSintoma(sintoma);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 10:
                    try{
                        Console.Write("Digite o mês: ");
                        int mes = int.Parse(Console.ReadLine()!);

                        this.aniversariantesDoMes(mes);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }while(opcao != 10);
    }
}
