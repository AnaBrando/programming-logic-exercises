namespace UnitTests;

public class AnalisadorDeTexto
{
    public static string PalavrasMaisFrequentes(string frase)
    {
        var dic = new Dictionary<string, int>();
        foreach (var palavra in frase.Split(" "))
        {
            if (!dic.ContainsKey(palavra))
            {
                dic[palavra] = 1;
            }
            else
            {
                dic[palavra]++;
            }
        }
        return dic.MaxBy(prop => prop.Value).Key;
    }
}