public class Solution
{
    //-5, -3, 0, 2, 4, 6, 8
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > target)
                break;
            
            int Start = i + 1, End = numbers.Length - 1;

            while (Start <= End)
            {
                int Middle = Start + (End - Start) / 2;
                int sum = numbers[i] + numbers[Middle];

                if (sum == target)
                {
                    result[0] = i + 1;
                    result[1] = Middle + 1;
                    return result;
                }


                if (sum > target)
                    End = Middle - 1;
                else
                    Start = Middle + 1;
            }
        }
        return new int[] {1,2};
    }
}