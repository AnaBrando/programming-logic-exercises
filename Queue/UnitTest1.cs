namespace Queue;

public class UnitTest1
{
    [Theory]
    [InlineData(new string[] { "Ana", "João", "Maria" }, 2, new string[] { "Ana", "João" })]
    [InlineData(new string[] { "Ana", "João" }, 5, new string[] { "Ana", "João" })]
    [InlineData(new string[] { }, 3, new string[] { })]
    [InlineData(new string[] { "Ana", "João", "Maria" }, 4, new string[] { "Ana", "João", "Maria", "Ana" })] // 🔹 CENÁRIO NOVO

    public void DeveAtenderFilaNaOrdem(string[] entrada, int n, string[] esperado)
    {
        var resultado = FilaExercicio.AtenderFila(entrada.ToList(), n);
        Assert.Equal(esperado, resultado);
    }
}