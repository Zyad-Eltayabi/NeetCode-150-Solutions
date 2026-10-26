public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        bool same = true;
        Check(ref p, ref q, ref same);
        return same;
    }

    private void Check(ref TreeNode p, ref TreeNode q, ref bool same)
    {
        if (!same)
            return;

        if(q == null && p == null)
            return;

        if ( (q != null && p == null || q == null && p != null) || p.val != q.val)
        {
            same = false;
            return;
        }


        Check(ref p.left, ref q.left, ref same);
        Check(ref p.right, ref q.right, ref same);

    }
}