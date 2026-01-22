1using System.Diagnostics.Metrics;
2
3public class Solution {
4    public int MajorityElement(int[] nums) {
5        Dictionary<int, int> elementCounts = new();
6        int majorityCount = nums.Length / 2;
7        int counter = 0;
8        int maxNumber = int.MinValue;
9        foreach (int num in nums)
10        {
11           
12            ref int count = ref System.Runtime.InteropServices.CollectionsMarshal
13                .GetValueRefOrAddDefault(elementCounts, num, out _);
14            
15            count++;
16
17            if (elementCounts[num] > majorityCount)
18            {
19                maxNumber = Math.Max(maxNumber, num);
20                counter++;
21            }
22            
23         
24            if (counter == 2)
25                break;
26        }
27        return maxNumber;
28    }
29}