/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return IsBalancedHelper(root, out _);
    }

    private bool IsBalancedHelper(TreeNode node, out int height)
    {
        if (node == null)
        {
            height = 0;
            return true;
        }
        int leftHeight, rightHeight;
        bool isLeftBalanced = IsBalancedHelper(node.left, out leftHeight);
        bool isRightBalanced = IsBalancedHelper(node.right, out rightHeight);
        height = Math.Max(leftHeight, rightHeight) + 1;
        return isLeftBalanced && isRightBalanced && Math.Abs(leftHeight - rightHeight) <= 1;
    }
}
