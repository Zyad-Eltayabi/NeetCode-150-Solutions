1public class Solution {
2    public int[] TopKFrequent(int[] nums, int k) 
3    {
4        var frequencyMap = new Dictionary<int,int>();
5        foreach (var num in nums)
6        {
7            ref var count = ref System.Runtime.InteropServices.CollectionsMarshal.GetValueRefOrAddDefault(frequencyMap, num, out bool exists);
8           if (exists)
9               count++;
10           else
11                count = 1;
12        }  
13
14        return frequencyMap
15            .OrderByDescending(kv => kv.Value)
16            .Take(k)
17            .Select(kv => kv.Key)
18            .ToArray();  
19    }
20}