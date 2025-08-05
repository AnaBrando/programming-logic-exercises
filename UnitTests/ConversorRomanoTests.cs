namespace UnitTests;

using Xunit;

public class ConversorRomanoTests
{
    [Theory]
    [InlineData(1, "I")] // menor número romano
    [InlineData(3, "III")]    // repetição de I
    [InlineData(4, "IV")]     // regra de subtração
    [InlineData(5, "V")]      // múltiplo direto
    [InlineData(9, "IX")]     // subtração para 9
    [InlineData(10, "X")]     // base 10
    // [InlineData(14, "XIV")]   // composição
    // [InlineData(40, "XL")]    // subtração para 40
    // [InlineData(44, "XLIV")]  // composição com subtração
    // [InlineData(58, "LVIII")] // L + V + III
    // [InlineData(90, "XC")]    // subtração para 90
    // [InlineData(199, "CXCIX")] // 100 + 90 + 9
    // [InlineData(3999, "MMMCMXCIX")] // maior número romano padrão
    public void DeveConverterInteiroParaRomano(int numero, string esperado)
    {
        var resultado = ConversorRomano.InteiroParaRomano(numero);
        Assert.Equal(esperado, resultado);
    }
}