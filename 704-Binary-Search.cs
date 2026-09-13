public class Solution
{
    public int Search(int[] nums, int target)
    {
        int index = Array.BinarySearch(nums, target);

        if (index >= 0)
            return index;

        return -1;

    }
}