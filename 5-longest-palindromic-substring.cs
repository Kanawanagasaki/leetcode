public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 1)
            return s;
        else if (s.Length == 2)
            return s[0] == s[1] ? s : s[0..1];

        var bestSubstring = s[0..1];

        for (int i = 1; i < s.Length - 1; i++)
        {
            int leftShift = 0;
            int rightShift = 0;
            while (0 < i - leftShift && s[i - leftShift - 1] == s[i])
                leftShift++;
            while (i + rightShift < s.Length - 1 && s[i + rightShift + 1] == s[i])
                rightShift++;
            int toSkip = rightShift;

            var maxJ = System.Math.Min(i - leftShift, s.Length - i - rightShift - 1);
            for (int j = 0; j < maxJ; j++)
            {
                if (s[i - leftShift - 1] == s[i + rightShift + 1])
                {
                    leftShift++;
                    rightShift++;
                }
            }

            if (bestSubstring.Length < rightShift + leftShift + 1)
                bestSubstring = s[(i - leftShift)..(i + rightShift + 1)];

            i += toSkip;
        }

        return bestSubstring;
    }
}
