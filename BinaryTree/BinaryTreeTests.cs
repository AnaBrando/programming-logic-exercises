using BinaryTree;
using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void DeveRetornarValorMaximo_Simples()
    {
        var root = new TreeNode(5);
        root.Left = new TreeNode(3);
        root.Right = new TreeNode(7);
        root.Left.Left = new TreeNode(2);
        root.Left.Right = new TreeNode(4);
        root.Right.Right = new TreeNode(9);

        var resultado = ExercicioArvore.EncontrarMaximo(root);
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarValorMaximo_QuandoSoTemUmNo()
    {
        var root = new TreeNode(10);

        var resultado = ExercicioArvore.EncontrarMaximo(root);
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void DeveRetornarIntMinValue_QuandoArvoreForNula()
    {
        TreeNode root = null;

        var resultado = ExercicioArvore.EncontrarMaximo(root);
        Assert.Equal(int.MinValue, resultado); 
    }

    [Fact]
    public void DeveRetornarMaximo_QuandoValoresNegativos()
    {
        var root = new TreeNode(-5);
        root.Left = new TreeNode(-10);
        root.Right = new TreeNode(-2);

        var resultado = ExercicioArvore.EncontrarMaximo(root);
        Assert.Equal(-2, resultado);
    }
    
        [Fact]
        public void DeveRetornarQuantidadeDeNosNoNivel0()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
            root.Right = new TreeNode(7);
    
            var resultado = ExercicioArvore.CountAtLevel(root, 0);
            Assert.Equal(1, resultado);
        }
    
        [Fact]
        public void DeveRetornarQuantidadeDeNosNoNivel2()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
            root.Right = new TreeNode(7);
            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(4);
            root.Right.Right = new TreeNode(9);
    
            var resultado = ExercicioArvore.CountAtLevel(root, 2);
            Assert.Equal(3, resultado);
        }
    
        [Fact]
        public void DeveRetornarZero_QuandoNivelNaoExiste()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
    
            var resultado = ExercicioArvore.CountAtLevel(root, 3);
            Assert.Equal(0, resultado);
        }
}