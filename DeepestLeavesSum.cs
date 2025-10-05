namespace Leetcode;

public class DeepestLeavesSum
{
    public int DeepestLeavesSumFunc(TreeNode root)
    {
        int res = 0;
        int levelMax = 1;
        DFS(root, 0, ref levelMax, ref res);
        return res;
    }

    public void DFS(TreeNode root, int level, ref int levelMax, ref int sum)
    {
        if (root == null) return;

        level++;
        if (levelMax < level)
        {
            levelMax = level;
            sum = 0;
        }

        if (level == levelMax)
            sum += root.val;

        DFS(root.left, level, ref levelMax, ref sum);
        DFS(root.right, level, ref levelMax, ref sum);
    }
}