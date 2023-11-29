using avaliacaoIndividual;
public class Consultorio{
    public List<Medico> Medicos { get; }
    public List<Paciente> Pacientes { get; }

    public Consultorio(){
        this.Medicos = new List<Medico>();
        this.Pacientes = new List<Paciente>();
    }

    public void addMedico(Medico medico){
        for (int i = 0; i < this.Medicos.Count; i++){
            if(this.Medicos[i].getCPF() == medico.getCPF() || this.Medicos[i].CRM == medico.CRM){
                throw new System.Exception("Este medico já está cadastrado");
            }
        }

        this.Medicos.Add(medico);
    }

    public void addPaciente(Paciente paciente){
        for (int i = 0; i < this.Pacientes.Count; i++){
            if(this.Pacientes[i].getCPF() == paciente.getCPF()){
                throw new System.Exception("Este paciente já está cadastrado");
            }
        }

        this.Pacientes.Add(paciente);
    }

}
