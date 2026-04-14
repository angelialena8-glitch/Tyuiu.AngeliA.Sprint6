using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AngeliA.Sprint6.Task3.V28.Lib
{
    public class Class1 : ISprint6Task3V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            int[,] res = matrix;

            for (int i = 0; i < cols; i++)
            {
                if (matrix[3, i] % 2 == 0)
                {
                    res[3, i] = 0;
                }
            }
            return res;
        }
    }
}
