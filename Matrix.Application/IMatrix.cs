namespace Matrix.Application
{
    public interface IMatrix
    {
        int[,] MatrixCreation(int a, int b);

        int MatrixSum(int[,] matrix);
    }
}
