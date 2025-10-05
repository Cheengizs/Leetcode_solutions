namespace leetcode_tasks;

public class ShortestWay
{
    public int MinPathSum(int[][] grid)
    {
        int[,] matrix = new int[grid.Length, grid[0].Length];
        matrix[0, 0] = grid[0][0];


        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
                matrix[i, j] = Int32.MaxValue;
        }

        matrix[0, 0] = grid[0][0];
        for (int j = 1; j < grid[0].Length; j++)
        {
            matrix[0,j] = grid[0][j] + matrix[0,j - 1];   
        }

        for (int i = 1; i < grid.Length; i++)
        {
            matrix[i,0]= grid[i][0] + matrix[i - 1,0];
        }
        
        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[i].Length; j++)
            {
                matrix[i, j] = Math.Min(grid[i][j] + matrix[i - 1,j], grid[i][j]+ matrix[i, j - 1] );
            }
        }
        
        return matrix[grid.Length-1,grid[0].Length-1];
    }
}