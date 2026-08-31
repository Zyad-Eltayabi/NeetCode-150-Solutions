public class Solution
{
    public bool IsPalindrome(string s)
    {
      
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                if (char.IsLower(c))
                    sb.Append(c);
                else 
                    sb.Append(char.ToLower(c));
            }
            else if (char.IsDigit(c))
                sb.Append(c);
        }
        int len = sb.Length;
        int halfLen = len / 2;
        for (int i = 0; i < halfLen; i++)
        {
            if (sb[i] != sb[len - 1 - i])
                return false;
        }
        return true;
    }
}