namespace UnitTests;

public class UnitTest1
{
    [Theory]
    [InlineData("gato cachorro gato", "gato")]
    [InlineData("ana joao ana ana maria joao", "ana")]
    [InlineData("sol lua lua sol lua", "lua")]
    [InlineData("único", "único")]
    public void DeveRetornarPalavraMaisFrequente_Simples(string entrada, string saida)
    {
        var resultado = AnalisadorDeTexto.PalavrasMaisFrequentes(entrada);
        Assert.Equal(resultado,saida);
    }
}