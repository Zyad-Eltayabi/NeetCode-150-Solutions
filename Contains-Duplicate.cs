1public class Solution {
2    public bool ContainsDuplicate(int[] nums) {
3        HashSet<int> set = new HashSet<int>();
4        foreach (var item in nums)
5        {
6            if (set.Contains(item))
7                return true;
8            set.Add(item);
9        }
10        return false;
11    }
12}
13