namespace Queue;

public class FilaExercicio
{
    public static List<string> AtenderFila(List<string> pessoas, int n)
    {
        var queue = new Queue<string>(pessoas);
        var atendidos = new List<string>();

        while (n > 0 && queue.Count > 0)
        {
            atendidos.Add(queue.Dequeue());
            n--;
        }

        return atendidos;
    }
}