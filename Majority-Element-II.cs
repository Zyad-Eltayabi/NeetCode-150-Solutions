1public class Solution
2{
3    public IList<int> MajorityElement(int[] nums)
4    {
5        
6        Dictionary<int, int> elementCounts = new();
7        
8        
9        foreach (int num in nums)
10        {
11           
12            ref int count = ref System.Runtime.InteropServices.CollectionsMarshal
13                .GetValueRefOrAddDefault(elementCounts, num, out _);
14            
15            count++;
16        }
17        
18        int majorityCount = nums.Length / 3;
19
20     
21        List<int> result = new(capacity: 2);
22        
23  
24        foreach (var kvp in elementCounts)
25        {
26            if (kvp.Value > majorityCount)
27                result.Add(kvp.Key);
28            
29         
30            if (result.Count == 2)
31                break;
32        }
33        
34        return result;
35            }
36}