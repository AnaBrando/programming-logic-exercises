using System.Text;

namespace UnitTests;

public class ConversorRomano
{
    public static IEnumerable<char> InteiroParaRomano(int numero)
    {
        var output = new StringBuilder();
        var map = new (int valor, string simbolo)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        while (numero != 0)
        {
            foreach (var value in map)
            {
                if (numero >= value.valor)
                {
                    output.Append(value.simbolo);
                    numero -= value.valor;
                }
            }
        }


        return output.ToString();
    }
}