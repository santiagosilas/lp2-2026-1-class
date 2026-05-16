namespace Sistema.Entidades;
public class Individuo
{
    public readonly string nome;
    public string Apelido {get; private set;}
    public required string Cpf {get; set;}
    public Individuo(string nome)
    {
        this.nome = nome;
    }
}