1public class Solution
2{
3    private bool IsValidBlock(char[][] board, int startRow, int startCol)
4    {
5        HashSet<char> seen = new();
6        for (int i = startRow; i < startRow + 3; i++)
7        {
8            for (int j = startCol; j < startCol + 3; j++)
9            {
10                char c = board[i][j];
11                if (c == '.')
12                    continue;
13                if (seen.Contains(c))
14                    return false;
15                seen.Add(c);
16            }
17        }
18        return true;
19    }
20    public bool IsValidSudoku(char[][] board)
21    {
22        Dictionary<int, HashSet<char>> rows = new();
23        Dictionary<int, HashSet<char>> cols = new();
24        for (int i = 0; i < 9; i++)
25        {
26            rows[i] = new HashSet<char>();
27            cols[i] = new HashSet<char>();
28        }
29        for (int i = 0; i < 9; i++)
30        {
31            for (int j = 0; j < 9; j++)
32            {
33                if (i % 3 == 0 && j % 3 == 0)
34                {
35                    if (!IsValidBlock(board, i, j))
36                        return false;
37                }
38                char c = board[i][j];
39                if (c == '.')
40                    continue;
41                if (rows[i].Contains(c))
42                    return false;
43                rows[i].Add(c);
44                if (cols[j].Contains(c))
45                    return false;
46                cols[j].Add(c);
47            }
48        }
49        return true;
50    }
51}