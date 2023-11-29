using avaliacaoIndividual;

Consultorio consultorio = new Consultorio();

Medico medico = new Medico("João", "01/01/2000", "12345678901", "123456");
Medico medica = new Medico();

medica.Nome = "Maria";
medica.DataNascimento = DateTime.Parse("01/01/1990");
medica.setCPF("12345654321");
medica.CRM = "987654";

consultorio.addMedico(medico);
consultorio.addMedico(medica);

Medico medico2 = new Medico("Helder", "01/01/1990", "12345678901", "123456");
consultorio.addMedico(medico2);
