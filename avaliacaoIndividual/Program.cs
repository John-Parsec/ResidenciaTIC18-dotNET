using avaliacaoIndividual;


Consultorio consultorio = new Consultorio();

//Para testar com menu:
//Consultorio.menu();

Medico medico = new Medico("João", "01/01/2000", "12345678901", "123456");
Medico medica = new Medico();

medica.Nome = "Maria";
medica.DataNascimento = DateTime.Parse("01/11/1990");
medica.setCPF("12345654321");
medica.CRM = "987654";

try{
    medica.DataNascimento = DateTime.Parse("01/11/2021");
}
catch(Exception e){
    Console.WriteLine(e.Message);
}

consultorio.addMedico(medico);
consultorio.addMedico(medica);

Medico medico2 = new Medico("Helder", "01/01/1990", "12345678901", "123456");
consultorio.addMedico(medico2);


Paciente paciente = new Paciente("Arthur", DateTime.Parse("15/09/2001"), "16724538267", "Masculino");
paciente.addSintoma("Febre");

try{
    Paciente paciente2 = new Paciente("Rafaela", "09/3/2003", "92076145302", "F");
}catch(Exception e){
    Console.WriteLine(e.Message);
}


Paciente paciente3 = new Paciente("Rafaela", "09/3/2003", "92076145302", "Feminino");
paciente3.addSintoma("Dor de cabeça");

Paciente paciente4 = new Paciente("Rafael", "09/11/2001", "92072645302", "Masculino");
paciente4.addSintoma("Febre");

consultorio.addPaciente(paciente);
consultorio.addPaciente(paciente3);
consultorio.addPaciente(paciente4);

Console.WriteLine("Médicos:");
foreach (Medico m in consultorio.Medicos){
    Console.WriteLine($"Nome: {m.Nome} | Data de Nascimento: {m.DataNascimento} | CPF: {m.getCPF()} | CRM: {m.CRM}");
}

Console.WriteLine("\nPacientes:");
foreach (Paciente p in consultorio.Pacientes){
    Console.WriteLine($"Nome: {p.Nome} | Data de Nascimento: {p.DataNascimento} | CPF: {p.getCPF()} | Sexo: {p.Sexo}");
}



consultorio.medicosIdadeEntre(20, 30);
Console.WriteLine($"\n");


consultorio.pacientesIdadeEntre(20, 30);
Console.WriteLine($"\n");

consultorio.pacientesPorSexo("masculino");
Console.WriteLine($"\n");

consultorio.pacientesOrdemAlfabetica();
Console.WriteLine($"\n");

consultorio.pacientesComSintoma("febre");
Console.WriteLine($"\n");

try{
    consultorio.aniversariantesDoMes(13);
}catch(Exception e){
    Console.WriteLine(e.Message);
}

consultorio.aniversariantesDoMes(11);


//Para testar com menu:
//Consultorio.menu();

