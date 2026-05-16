namespace Sistema.Utils;

public class Relatorio
{
    public void GerarRelatorio()
    {
        Console.WriteLine("Gerado!");
    }
    public bool GerarRelatorioHtml()
    {
        try
        {
            //throw new NotImplementedException();
            return true;
        } catch(Exception)
        {
            return false;
        }
    }
}
