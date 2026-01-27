1public class Solution
2{
3    public void SortColors(int[] nums)
4    {
5        int len = nums.Length;
6
7        bool loop = true;
8        // sort the first color '0'
9        while (loop)
10        {
11            for (int i = 0; i < len; i++)
12            {
13                if (nums[i] != 0)
14                {
15                    for (int j = i + 1; j < len; j++)
16                    {
17                        if (nums[j] == 0)
18                        {
19                            int temp = nums[i];
20                            nums[i] = 0;
21                            nums[j] = temp;
22                            break;
23                        }
24                        if(j == len - 1)
25                            i = len;
26                    }
27                }
28            }
29            loop = false;
30        }
31
32        loop = true;
33        // sort the first color '1'
34        while (loop)
35        {
36            for (int i = 0; i < len; i++)
37            {
38                if (nums[i] == 2)
39                {
40                    for (int j = i + 1; j < len; j++)
41                    {
42                        if (nums[j] == 1)
43                        {
44                            int temp = nums[i];
45                            nums[i] = 1;
46                            nums[j] = temp;
47                            break;
48                        }
49                        if (j == len - 1)
50                            i = len;
51                    }
52                    
53                }
54            }
55            loop = false;
56        }
57    }
58}