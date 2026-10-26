public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null) return false;
        return IsSameTree(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode s, TreeNode t)
    {
        if (s == null && t == null) return true;
        if (s == null || t == null) return false;
        if (s.val != t.val) return false;
        return IsSameTree(s.left, t.left) && IsSameTree(s.right, t.right);
    }
}