public class Solution
{
    public int[][] SortMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            int currRow = i;
            int currCol = 0;

            SortDiagonal(matrix, currRow, currCol, (a, b) => a - b);
        }

        for (int j = 1; j < matrix.Length; j++)
        {
            int currRow = 0;
            int currCol = j;
            SortDiagonal(matrix, currRow, currCol, (a, b) => b - a);
        }

        return matrix;
    }

    public void SortDiagonal(int[][] matrix, int rowStart, int colStart, Func<int, int, int> cmpFunc)
    {
        for (int i = rowStart, j = colStart;
             i < matrix.Length && j < matrix.Length;
             i++,
             j++
            )
        {
            var minIndex = (i, j);
            for (int k = i + 1, l = j + 1;
                 k < matrix.Length && l < matrix.Length;
                 k++,
                 l++)
            {
                if (cmpFunc(matrix[minIndex.i][minIndex.j], matrix[k][l]) < 0)
                {
                    minIndex.i = k;
                    minIndex.j = l;
                }
            }

            (matrix[minIndex.i][minIndex.j], matrix[i][j]) = (matrix[i][j], matrix[minIndex.i][minIndex.j]);
        }
    }
}