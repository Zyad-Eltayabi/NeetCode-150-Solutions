1public class Solution
2{
3    public int[] GetConcatenation(int[] nums)
4    {
5        int length = nums.Length;
6        int[] result = new int[nums.Length * 2];
7        for (int i = 0; i < length; i++)
8        {
9            result[i] = nums[i];
10            result[i + length] = nums[i];
11        }
12        return result;
13    }
14}