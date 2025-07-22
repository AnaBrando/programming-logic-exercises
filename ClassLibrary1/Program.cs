namespace ClassLibrary1;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(SaoAnagramas("amor", "roma"));     // true
        Console.WriteLine(SaoAnagramas("casa", "saca"));     // true
        Console.WriteLine(SaoAnagramas("joia", "aijoa"));    // false
        Console.WriteLine(SaoAnagramas("aaa", "aa"));        // false
        Console.WriteLine(SaoAnagramas("Ana", "naa"));       // true (se case-insensitive)
    }

    public static bool SaoAnagramas(string palavra1, string palavra2)
    {
        var dic1 = ContarLetras(palavra1);
        var dic2 = ContarLetras(palavra2);

        if (dic1.Count != dic2.Count) return false;

        foreach (var pair in dic1)
        {
            if (!dic2.ContainsKey(pair.Key)) return false;
            if (dic2[pair.Key] != pair.Value) return false;
            
        }
        // TODO: Sua lógica aqui
        return false;
    }
    
    public static Dictionary<char,int> ContarLetras(string entrada)
    {
        var dic = new Dictionary<char, int>();
        foreach (var palavra in entrada.ToLower().Trim())
        {
            if (dic.ContainsKey(palavra))
            {
                dic[palavra]++;
            }
            else
            {
                dic[palavra] = 1;
            }
        }
        return dic;
    }
}