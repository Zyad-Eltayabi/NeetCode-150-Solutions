1public class Solution {
2    public int[] ProductExceptSelf(int[] nums) {
3        int len = nums.Length;
4        int[] rightPrefixArray = new int[len];
5        int[] leftPrefixArray = new int[len];
6        int leftValue = 1;
7        int rightValue = 1;
8        for (int i = 0; i < len; i++) {
9            leftPrefixArray[i] = leftValue * nums[i];
10            leftValue = leftPrefixArray[i];
11            rightPrefixArray[len - 1 - i] = rightValue * nums[len - 1 - i];
12            rightValue = rightPrefixArray[len - 1 - i];
13        }
14        int[] result = new int[len];
15        for (int i = 0; i < len; i++)
16        {
17            int leftProduct = i == 0 ? 1 : leftPrefixArray[i - 1];
18            int rightProduct = i == len - 1 ? 1 : rightPrefixArray[i + 1];
19            result[i] = leftProduct * rightProduct;
20        }
21        return result;
22    }
23}