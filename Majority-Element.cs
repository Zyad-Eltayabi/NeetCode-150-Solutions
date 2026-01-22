1using System.Diagnostics.Metrics;
2
3public class Solution {
4    public int MajorityElement(int[] nums) {
5        Dictionary<int, int> elementCounts = new();
6        
7        
8        foreach (int num in nums)
9        {
10           
11            ref int count = ref System.Runtime.InteropServices.CollectionsMarshal
12                .GetValueRefOrAddDefault(elementCounts, num, out _);
13            
14            count++;
15        }
16        
17        int majorityCount = nums.Length / 2;
18
19     
20        
21        int counter = 0;
22        int maxNumber = int.MinValue;
23        foreach (var kvp in elementCounts)
24        {
25            if (kvp.Value > majorityCount)
26            {
27                maxNumber = Math.Max(maxNumber, kvp.Key);
28                counter++;
29            }
30            
31         
32            if (counter == 2)
33                break;
34        }
35        
36        return maxNumber;
37    }
38}