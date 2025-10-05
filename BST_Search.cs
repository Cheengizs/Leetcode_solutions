namespace Leetcode;

public class BST_Search
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null) return new TreeNode(val);
        SearchPos(root, val);
        return root;
    }

    public void SearchPos(TreeNode root, int val)
    {
        if (root != null && root.val < val)
        {
            if (root.right != null)
            {
                SearchPos(root.right, val);
            }
            else
            {
                root.right = new TreeNode(val);
                return;
            }
        }
        else if (root != null && root.val > val)
        {
            if (root.left != null)
            {
                SearchPos(root.left, val);
            }
            else
            {
                root.left = new TreeNode(val);
                return;
            }
        }
    }
}