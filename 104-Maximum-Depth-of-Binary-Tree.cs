public class Solution
{
    public int MaxDepth(TreeNode root, int depth = 0)
    {
        if (root == null)
        {
            return depth;
        }
        depth++;
        int leftDepth = MaxDepth(root.left, depth);
        int rightDepth = MaxDepth(root.right, depth);
        return Math.Max(leftDepth, rightDepth);
    }
}