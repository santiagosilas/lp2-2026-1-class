
using Sistema.Interfaces;

namespace Sistema.Entidades;

public class Produto : IProduto
{
    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool VerificarDisponibilidade()
    {
        throw new NotImplementedException();
    }
}
