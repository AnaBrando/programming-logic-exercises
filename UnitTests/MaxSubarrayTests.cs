namespace UnitTests;

public class MaxSubarrayTests
{
    [Theory]
    [InlineData(new int[] { 1, -3, 2, 1, -1 }, 3)]
    [InlineData(new int[] { -2, -3, -1, -4 }, -1)]
    [InlineData(new int[] { 5, 4, -1, 7, 8 }, 23)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
    [InlineData(new int[] { -1 }, -1)]
    public void DeveEncontrarMaiorSomaSubarray(int[] entrada, int esperado)
    {
        var resultado = MaxSubarray.MaxSubarraySum(entrada);
        Assert.Equal(esperado, resultado);
    }
}

public class MaxSubarray
{
    public static int MaxSubarraySum(int[] entrada)
    {
        int maxSum = entrada[0];
        int currentSum = entrada[0];
        for (int i = 1; i < entrada.Length; i++)
        {
            if (currentSum + entrada[i] > entrada[i])
            {
                currentSum = currentSum + entrada[i];
            }
            else
            {
                currentSum = entrada[i];
            }

            if (currentSum > maxSum)
                maxSum = +currentSum;
        }

        return maxSum;
    }
}