namespace Sistema.Entidades;

public class Pessoa(string cpf)
{
    public string Cpf {get; set;} = cpf;
    public virtual bool validarCpf()
    {
        throw new NotImplementedException();
    }
    public bool consultarCpfSerasa()
    {
        throw new NotImplementedException();
    }
}