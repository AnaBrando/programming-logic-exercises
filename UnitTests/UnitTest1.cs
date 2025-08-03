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
        Assert.Equal(resultado, saida);
    }

    [Theory]
    [InlineData("sol lua céu", 3, "sol", "lua", "céu")]
    [InlineData("casa amor vida", 4, "casa", "amor", "vida")]
    public void Deve_Retornar_Grupo_Por_Tamanho(string entrada, int tamanhoEsperado, string p1, string p2, string p3)
    {
        // Act
        var resultado = Exercice2.AgruparPorTamanho(entrada);

        // Assert
        Assert.True(resultado.ContainsKey(tamanhoEsperado));
        Assert.Contains(p1, resultado[tamanhoEsperado]);
        Assert.Contains(p2, resultado[tamanhoEsperado]);
        Assert.Contains(p3, resultado[tamanhoEsperado]);
    }


    [Theory]
    [InlineData("casa cachorro cavalo", 'c', 3)]
    [InlineData("gato girafa galinha", 'g', 3)]
    [InlineData("sol sapo sol", 's', 3)]
    [InlineData("Ana Antonio ana", 'a', 3)]
    [InlineData("   ", 'a', 0)] // Frase vazia
    public void DeveRetornarPrimeiraPalavraRepetida(string entrada, char esperado, int tamanho)
    {
        var resultado = PalavraAgrupada.AgruparPorInicial(entrada);

        Assert.True(resultado.ContainsKey(esperado));
        Assert.Equal(esperado, resultado[esperado].Count);
    }

    [Theory]
    [InlineData("casa sol arte mundo", "mundo")]
    [InlineData("ana joao maria", "maria")]
    [InlineData("aaaaa bbbb cc", null)]
    [InlineData("sol lua mar", "sol")]
    [InlineData("Arte Sol Céu", "Arte")] // testa com letras maiúsculas
    public void DeveRetornarMaiorPalavraSemLetrasRepetidas(string entrada, string esperado)
    {
        var resultado = PalavraUnica.MaiorPalavraSemLetrasRepetidas(entrada);
        Assert.Equal(esperado, resultado);
    }
}

public static class PalavraUnica
{
    public static string MaiorPalavraSemLetrasRepetidas(string frase)
    {
        var words = frase.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var dictionary = new Dictionary<char, int>();

        foreach (var item in words)
        {
            var raw = item.ToLower().Trim();

            foreach (var letra in raw)
            {
                if (dictionary.ContainsKey(letra))
                {
                    dictionary[letra]++;
                }
                else
                {
                    dictionary[letra] = 1;
                }
            }
        }

        return dictionary.Min(prop => prop.Key).ToString();
    }
}

public static class PalavraRepetida
{
    public static string PrimeiraPalavraRepetida(string entrada)
    {
        var words = entrada.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var seen = new HashSet<string>();

        foreach (var item in words)
        {
            var raw = item.ToLower().Trim();
            if (seen.Contains(raw))
            {
                return raw;
            }

            seen.Add(raw);
        }

        return null;
    }
}