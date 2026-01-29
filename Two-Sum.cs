1public class Solution {
2    public int[] TwoSum(int[] nums, int target) {
3        Dictionary<int,int> numberWithIndex = [];
4        for(int i = 0; i < nums.Length; i++) {
5            int complement = target - nums[i];
6            if(numberWithIndex.ContainsKey(complement) && numberWithIndex[complement] != i) 
7                return new int[] { numberWithIndex[complement], i };
8            
9            numberWithIndex[nums[i]] = i;
10        }
11        return new int[] {};
12        }
13}
14