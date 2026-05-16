namespace Sistema.Interfaces
{
    public interface IProduto
    {
        public string Nome {get; set;}
        public bool VerificarDisponibilidade();

        public void atualizarEstoque(int qtde)
        {
            // ... 
        } 
    }
}