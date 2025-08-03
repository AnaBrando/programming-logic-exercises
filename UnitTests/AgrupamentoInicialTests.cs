namespace UnitTests;

public class AgrupamentoInicialTests
{
    [Theory]
    [InlineData("casa cachorro cavalo", 'c', 3)]
    [InlineData("gato girafa galinha", 'g', 3)]
    [InlineData("sol sapo sol", 's', 3)]
    [InlineData("Ana Antonio ana", 'a', 3)]
    [InlineData("   ", 'a', 0)] // Frase vazia
    public void DeveAgruparPalavrasPorInicial(string frase, char letraEsperada, int quantidadeEsperada)
    {
        var resultado = PalavraAgrupada.AgruparPorInicial(frase);

        Assert.True(resultado.ContainsKey(letraEsperada));
        Assert.Equal(quantidadeEsperada, resultado[letraEsperada].Count);
    }
}