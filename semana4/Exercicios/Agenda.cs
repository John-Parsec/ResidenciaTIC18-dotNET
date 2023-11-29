using semana4.Exercicios;
public class Agenda{
    List<Contato> contatos = new List<Contato>();

    public void AdicionarContato(Contato contato){
        foreach(Contato c in contatos){
            if(c.cpf == contato.cpf){
                throw new Exception("CPF já cadastrado");
            }
        }

        contatos.Add(contato);
    }

    public void RemoverContato(Contato contato){
        contatos.Remove(contato);
    }
}
