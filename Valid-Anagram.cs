1public class Solution
2{
3    public bool IsAnagram(string s, string t)
4    {
5        if (s.Length != t.Length)
6            return false;
7
8        Dictionary<char, int> pairs1 = new();
9        Dictionary<char, int> pairs2 = new();
10
11        for (int i = 0; i < s.Length; i++)
12        {
13            if (pairs1.ContainsKey(s[i]))
14                pairs1[s[i]]++;
15            else
16                pairs1.Add(s[i], 1);
17
18            if (pairs2.ContainsKey(t[i]))
19                pairs2[t[i]]++;
20            else
21                pairs2.Add(t[i], 1);
22        }
23
24        foreach (var item in pairs1)
25        {
26            if(!pairs2.Keys.Contains(item.Key) || item.Value != pairs2[item.Key])
27                return false;
28        }
29        return true;
30    }
31}
32