namespace BinaryTree;

public class TreeNode
{
    public TreeNode Right;
    public TreeNode Left;
    public int Value;

    public TreeNode(int value)
    {
        Value = value;
        Right = null!;
        Left = null!;
    }
}

public class ExercicioArvore
{
    public static int EncontrarMaximo(TreeNode root)
    {
        if (root is null) return int.MinValue;
        var maximoValor = int.MinValue;

        var currentNode = new List<TreeNode>() { root };

        while (currentNode.Count > 0)
        {
            var nextNode = new List<TreeNode>();
            foreach (var item in currentNode)
            {
                if (item.Value > maximoValor) maximoValor = item.Value;

                if (item.Left != null)
                    nextNode.Add(item.Left);

                if (item.Right is not null)
                    nextNode.Add(item.Right);
            }

            currentNode = nextNode;
        }

        return maximoValor;
    }

    public static int CountAtLevel(TreeNode root, int level)
    {
        if (root == null) return 0;

        int count = 0;
        var currentRoot = new List<TreeNode>() { root };

        while (currentRoot.Count > 0)
        {
            if (count == level)
            {
                return currentRoot.Count;
            }

            var nextRoot = new List<TreeNode>();
            foreach (var item in currentRoot)
            {
                if (item.Left != null)
                    nextRoot.Add(item.Left);
                if (item.Right != null)
                    nextRoot.Add(item.Right);
            }

            count++;
            currentRoot = nextRoot;
        }

        return currentRoot.Count;
    }
}