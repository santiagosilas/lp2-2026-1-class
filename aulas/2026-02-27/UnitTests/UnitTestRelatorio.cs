using Sistema.Utils;
namespace UnitTests;

public class UnitTestRelatorio
{
    [Fact]
    public void TestGerarRelatorioHtml()
    {
        Relatorio r = new Relatorio();
        Assert.Equal(true, r.GerarRelatorioHtml());
    }
}
