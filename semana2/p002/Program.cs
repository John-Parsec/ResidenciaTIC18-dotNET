﻿/*
Requisitos do Projeto:
O sistema deve permitir a criação de tarefas, incluindo um título, descrição e data de
vencimento.
Deve ser possível listar todas as tarefas criadas.
Os usuários devem poder marcar tarefas como concluídas.
O sistema deve fornecer uma lista de tarefas pendentes e uma lista de tarefas
concluídas.
Os usuários devem ser capazes de excluir tarefas.
Implemente uma pesquisa que permita aos usuários encontrar tarefas com base em
palavras-chave.
O sistema deve fornecer estatísticas básicas, como o número de tarefas concluídas e
pendentes, a tarefa mais antiga e a tarefa mais recente.

Use um Array ou uma List para armazenar as tarefas.
Use estruturas de controle de fluxo (if, else, for, while, do-while, foreach) para
implementar as funcionalidades do sistema.
Use a classe DateTime para lidar com datas e prazos.
Solicite entradas do usuário para criar, editar e excluir tarefas.
Use strings para armazenar os títulos e descrições das tarefas.
*/

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
