namespace UnitTests;

public class PalavraAgrupada
{
    public static Dictionary<char, List<string>> AgruparPorInicial(string frase)
    {
        var content = frase.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var result = new Dictionary<char, List<string>>();

        foreach (var item in content)
        {
            var raw = item.ToLower().Trim();
            var firstLetter = raw.First();

            if (!char.IsLetter(firstLetter))
                continue;

            if (result.TryGetValue(firstLetter, out var value))
            {
                value.Add(raw);
            }
            else
            {
                result[firstLetter] = new List<string>() { raw };
            }
        }

        return result;
    }
}