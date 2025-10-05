namespace leetcode_tasks;

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

public class TreeTask
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        TreeNode res = FillNode(left, right, nums);
        return res;
    }

    public TreeNode FillNode(int left, int right, int[] nums)
    {
        if (left > right)
            return null;

        int mid = (left + right) / 2;
        TreeNode node = new TreeNode(nums[mid]);

        node.left  = FillNode(left, mid - 1, nums);
        node.right = FillNode(mid + 1, right, nums);

        return node;
    }
}