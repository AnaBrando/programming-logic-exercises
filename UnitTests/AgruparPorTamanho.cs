namespace UnitTests;

public static class Exercice2
{
    public static Dictionary<int, List<string>> AgruparPorTamanho(string frase)
    {
        var content = frase.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var dic = new Dictionary<int, List<string>>();

        foreach (var item in content)
        {
            var raw = item.ToLower().Trim();
            if (dic.TryGetValue(raw.Length, out var value))
            {
                value.Add(raw);
            }
            else
            {
                dic.Add(raw.Length, new List<string>() { raw });
            }
        }

        return dic;
    }
}