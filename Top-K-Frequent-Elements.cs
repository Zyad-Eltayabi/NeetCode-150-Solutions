1public class Solution
2{
3    public int[] TopKFrequent(int[] nums, int k)
4    {
5        var frequencyMap = new Dictionary<int, int>();
6        foreach (var num in nums)
7        {
8            ref var count = ref System.Runtime.InteropServices.CollectionsMarshal.GetValueRefOrAddDefault(frequencyMap, num, out bool exists);
9            if (exists)
10                count++;
11            else
12                count = 1;
13        }
14
15        List<List<int>> bucket= new List<List<int>>(new List<int>[nums.Length + 1]);
16        int endIndex = 0;
17        foreach (var kvp in frequencyMap)
18        {
19            int freq = kvp.Value;
20            if(bucket[freq] == null)
21                bucket[freq] = new List<int>();
22            bucket[freq].Add(kvp.Key);
23            endIndex = Math.Max(endIndex, freq);
24        }
25        List<int> result = new List<int>();
26        for (int i = endIndex; i >= 0 && result.Count < k; i--)
27        {
28            if (bucket[i] != null)
29            {
30                foreach (var num in bucket[i])
31                {
32                    result.Add(num);
33                    if (result.Count == k)
34                        break;
35                }
36            }
37        }
38        return result.ToArray();
39
40    }
41}