1public class Solution
2{
3    public int LongestConsecutive(int[] nums)
4    {
5        if (nums.Length == 0)
6            return 0;
7        HashSet<int> uniqueNumbers = [.. nums];
8        int longestStreak = 1;
9        foreach (int num in uniqueNumbers)
10        {
11            if (uniqueNumbers.Contains(num - 1))
12                continue;
13            int currentStreak = 1;
14            while (uniqueNumbers.Contains(num + currentStreak))
15            {
16                ++currentStreak;
17            }
18            longestStreak = Math.Max(longestStreak, currentStreak);
19        }
20        return longestStreak;
21    }
22}