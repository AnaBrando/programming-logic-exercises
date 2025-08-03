namespace Stack;
using Xunit;

public class PilhaTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("([]{})", true)]
    [InlineData("(]", false)]
    // [InlineData("([)]", false)]
    // [InlineData("((()))", true)]
    // [InlineData("", true)]
    public void DeveValidarSeStringEstaBalanceada(string entrada, bool esperado)
    {
        var resultado = PilhaExercicio.EstaBalanceada(entrada);
        Assert.Equal(esperado, resultado);
    }
}