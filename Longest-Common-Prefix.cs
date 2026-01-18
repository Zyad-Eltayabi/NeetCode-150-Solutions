1public class Solution
2{
3    public string LongestCommonPrefix(string[] strs)
4    {
5        if (strs == null || strs.Length == 0)
6            return string.Empty;
7        if (strs.Length == 1)
8            return strs[0];
9        StringBuilder longestCommonPrefix = new();
10        for (int i = 0; i < strs[0].Length; i++)
11        {
12            //string prefix = strs[0].Substring(0, i + 1);
13            longestCommonPrefix.Append(strs[0][i]);
14            string prefix = longestCommonPrefix.ToString();
15            for (int j = 1; j < strs.Length; j++)
16            {
17                if (!strs[j].StartsWith(prefix))
18                {
19                    return longestCommonPrefix.Remove(longestCommonPrefix.Length - 1, 1).ToString();
20                }
21            }
22        }
23        return longestCommonPrefix.ToString();
24    }
25}
26