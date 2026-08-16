public class Solution
{
    public int countTotalDays(int[] temperatures, int currentTemp, int i)
    {
        int days = 1;
        for (int j = i + 1; j < temperatures.Length; j++)
        {
            if (temperatures[j] > currentTemp)
                return days;
            else
                days++;
        }
        return 0;
    }
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] ans = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            ans[i] = countTotalDays(temperatures, temperatures[i], i);
        }
        ans[temperatures.Length - 1] = 0;
        return ans;
    }
}