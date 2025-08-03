namespace Stack;

/*
 *
 *
 *
 * Entrada: ( [ ] { } )
Stack:   
- Lê '('  → empilha '('
- Lê '['  → empilha '['
- Lê ']'  → desempilha '[' (ok)
- Lê '{'  → empilha '{'
- Lê '}'  → desempilha '{' (ok)
- Lê ')'  → desempilha '(' (ok)
Fim → Stack vazia → ✅ balanceado
 */
public class PilhaExercicio
{
    public static bool EstaBalanceada(string entrada)
    {
        var stack = new Stack<char>(); //LIFO
        var pares = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        foreach (char item in entrada)
        {
            if (pares.ContainsValue(item))
            {
                stack.Push(item);
            }

            if (pares.TryGetValue(item, out var pare))
            {
                if (stack.Count == 0) return false;

                var letter = stack.Peek();
                if (pare == letter)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}