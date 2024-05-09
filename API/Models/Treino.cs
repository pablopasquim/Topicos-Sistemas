namespace API.Models;

public class Treino{
    public string? Nome{get; set; }
    public string? Descricao {get; set; }
    public int id {get; set;}

    public Treino(string nome, string descricao){
        Nome = nome;
        Descricao = descricao;
    }
}

 