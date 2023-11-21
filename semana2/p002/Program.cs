class Tarefa{
    private string titulo;
    private string descricao;
    private DateTime data;
    private bool concluida;


    public Tarefa(string titulo = "", string descricao = "", DateTime data = new DateTime(), bool concluida = false){
        this.titulo = titulo;
        this.descricao = descricao;
        this.data = data;
        this.concluida = concluida;
    }

    public string Titulo{
        get{return titulo;}
        set{titulo = value;}
    }

    public string Descricao{
        get{return descricao;}
        set{descricao = value;}
    }

    public DateTime Data{
        get{return data;}
        set{data = value;}
    }

    public bool Concluida{
        get{return concluida;}
        set{concluida = value;}
    }
}

class Program{
    static void Main(string[] args){
        List<Tarefa> tarefas = new List<Tarefa>();
        int opcao = 0;
        do{
            Console.Clear();
            Console.WriteLine("1 - Criar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("4 - Listar tarefas concluídas");
            Console.WriteLine("5 - Listar tarefas pendentes");
            Console.WriteLine("6 - Excluir tarefa");
            Console.WriteLine("7 - Pesquisar tarefa");
            Console.WriteLine("8 - Estatísticas");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();
            
            switch(opcao){
                case 1:
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine() ?? "";
                    Console.Write("Descrição: ");
                    string descricao = Console.ReadLine() ?? "";
                    Console.Write("Data de vencimento (dd/mm/aaaa): ");
                    DateTime data = DateTime.Parse(Console.ReadLine() ?? "01/01/0001");
                    tarefas.Add(new Tarefa(titulo, descricao, data));
                    break;
                case 2:
                    Console.WriteLine("Tarefas:");
                    foreach(Tarefa t in tarefas){
                        Console.WriteLine($"Título: {t.Titulo}");
                        Console.WriteLine($"Descrição: {t.Descricao}");
                        Console.WriteLine($"Data de vencimento: {t.Data}");
                        Console.WriteLine($"Concluída: {(t.Concluida ? "Sim" : "Não")}");
                        Console.WriteLine();
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Tarefas:");
                    for(int i = 0; i < tarefas.Count; i++){
                        Console.WriteLine($"{i} - {tarefas[i].Titulo}");
                    }
                    Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
                    int indice = int.Parse(Console.ReadLine() ?? "-1");
                    tarefas[indice].Concluida = true;
                    break;
                case 4:
                    Console.WriteLine("Tarefas concluídas:");
                    foreach(Tarefa t in tarefas){
                        if(t.Concluida){
                            Console.WriteLine($"Título: {t.Titulo}");
                            Console.WriteLine($"Descrição: {t.Descricao}");
                            Console.WriteLine($"Data de vencimento: {t.Data}");
                            Console.WriteLine($"Concluída: {(t.Concluida ? "Sim" : "Não")}");
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Tarefas pendentes:");
                    foreach(Tarefa t in tarefas){
                        if(!t.Concluida){
                            Console.WriteLine($"Título: {t.Titulo}");
                            Console.WriteLine($"Descrição: {t.Descricao}");
                            Console.WriteLine($"Data de vencimento: {t.Data}");
                            Console.WriteLine($"Concluída: {(t.Concluida ? "Sim" : "Não")}");
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Tarefas:");
                    for(int i = 0; i < tarefas.Count; i++){
                        Console.WriteLine($"{i} - {tarefas[i].Titulo}");
                    }
                    Console.Write("Digite o número da tarefa que deseja excluir: ");
                    indice = int.Parse(Console.ReadLine() ?? "-1");
                    tarefas.RemoveAt(indice);
                    break;
                case 7:
                    Console.Write("Digite uma palavra-chave: ");
                    string palavra = Console.ReadLine() ?? "";
                    Console.WriteLine("Tarefas:");
                    foreach(Tarefa t in tarefas){
                        if(t.Titulo.Contains(palavra) || t.Descricao.Contains(palavra)){
                            Console.WriteLine($"Título: {t.Titulo}");
                            Console.WriteLine($"Descrição: {t.Descricao}");
                            Console.WriteLine($"Data de vencimento: {t.Data}");
                            Console.WriteLine($"Concluída: {(t.Concluida ? "Sim" : "Não")}");
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine($"Tarefas concluídas: {tarefas.Count(t => t.Concluida)}");
                    Console.WriteLine($"Tarefas pendentes: {tarefas.Count(t => !t.Concluida)}");
                    Console.WriteLine($"Tarefa mais antiga: {tarefas.OrderBy(t => t.Data).First().Titulo}");
                    Console.WriteLine($"Tarefa mais recente: {tarefas.OrderByDescending(t => t.Data).First().Titulo}");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }while(opcao != 0);
    } 
}