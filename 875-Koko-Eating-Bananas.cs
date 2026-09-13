public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int end = piles[piles.Length - 1];
        foreach (var item in piles)
        {
            end = Math.Max(item, end);
        }
        int start = 1;
        int minSpeed = int.MaxValue;
        while (start <= end)
        {
            int Middle = start + (end - start) / 2;
            int totalHours = 0;
            for (int i = piles.Length - 1; i >= 0; i--) {
                totalHours += (int)Math.Ceiling((double)piles[i] / Middle);
                if (totalHours > h)
                    break;
            }
            if (totalHours <= h)
            {
                minSpeed = Math.Min(minSpeed, Middle);
                end = Middle - 1;
            }
            else
            {
                start = Middle + 1;
            }
        }
        return minSpeed;
    }
}
