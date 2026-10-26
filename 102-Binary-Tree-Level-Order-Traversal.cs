public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) 
            return result;
        Traversal(root,ref result);
        return result;
    }

    private void Traversal(TreeNode root, ref IList<IList<int>> result, int depth = 0)
    {
        if (root != null)
        {
            if (result.Count > depth)
            {
                result[depth].Add(root.val);
            }
            else
            {
                List<int> ints = new List<int>();
                ints.Add(root.val);
                result.Insert(depth,ints);
            }

            Traversal(root.left, ref result, depth + 1);
            Traversal(root.right, ref result, depth + 1);
        }
    }
}