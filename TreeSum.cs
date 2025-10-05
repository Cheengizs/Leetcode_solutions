namespace Leetcode;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class TreeSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        int sum = 0;
        if (root == null) return false;
        return HasSumTree(root, targetSum, sum);
    }

    public bool HasSumTree(TreeNode head, int target, int sum)
    {
        if (head.left != null && head.right != null)
        {
            return HasSumTree(head.left, target, sum + head.val) || HasSumTree(head.right, target, sum + head.val);
        }
        else if (head.left != null)
        {
            return HasSumTree(head.left, target, sum + head.val);
        }
        else if (head.right != null)
        {
            return HasSumTree(head.right, target, sum + head.val);
        }

        return sum == target;
    }
}