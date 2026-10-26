public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        if(root == null)
            return new List<int>();
        Dictionary<int,List<int>> dict = new();
        Traversal(root, 0,ref dict);
        IList<int> result = new List<int>();
        foreach (var item in dict)
        {
            result.Add(item.Value[0]);
        }
        return result;
    }
    private void Traversal(TreeNode node, int level, ref Dictionary<int, List<int>> dict)
    {
        if (node == null)
            return;
        if(!dict.ContainsKey(level))
        {
            dict.Add(level, new List<int>(new int[] { node.val }));
        }
        else
        {
            dict[level].Add(node.val);
        }
        Traversal(node.right, level + 1,ref dict);
        Traversal(node.left, level + 1,ref dict);
    }
}