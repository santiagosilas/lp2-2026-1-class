namespace Sistema.Entidades;
public class Estudante(int id, string nome, string cpf):Pessoa(cpf)
{
    public int Id {get; set;} = id;
    public string Nome {get; set;} = nome;
    public string Apelido {get; set;} = string.Empty;

    public override bool validarCpf()
    {
        throw new NotImplementedException();
    }
    
    //public bool consultarCpfSerasa()
    //{
    //    throw new NotImplementedException();
    //}



}