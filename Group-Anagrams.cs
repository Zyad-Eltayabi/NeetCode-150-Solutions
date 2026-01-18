1public class Solution
2{
3    public IList<IList<string>> GroupAnagrams(string[] strs)
4    {
5        if (strs == null || strs.Length == 0)
6            return new List<IList<string>>();
7
8        Dictionary<string, List<string>> anagramGroups = [];
9        
10        foreach (string str in strs)
11        {
12            string key = GetFrequencyKey(str);
13            
14            ref var group = ref System.Runtime.InteropServices.CollectionsMarshal
15                .GetValueRefOrAddDefault(anagramGroups, key, out bool exists);
16            if (!exists)
17                group = new List<string>();
18            group!.Add(str);
19        }
20        
21        return anagramGroups.Values.ToList<IList<string>>();
22    }
23    
24    private string GetFrequencyKey(string str)
25    {
26        char[] counts = new char[26];
27        foreach (char c in str)
28            counts[c - 'a']++;
29        return new string(counts);
30    }
31}