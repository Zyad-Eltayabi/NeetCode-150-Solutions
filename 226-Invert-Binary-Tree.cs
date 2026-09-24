public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            (node.left, node.right) = (node.right, node.left);
            
            if(node.left != null)
                queue.Enqueue(node.left);

            if (node.right != null)
                queue.Enqueue(node.right);
        }
        return root;
    }
}