public class Solution
{
    public int ThirdMax(int[] nums)
    {
        int? a = null;
        int? b = null;
        int? c = null;
        foreach (var num in nums)
        {
            if (a == num || b == num || c == num)
                continue;

            if (a is null)
            {
                a = num;
                continue;
            }
            else if (b is null)
            {
                b = num;
                if (a < b)
                    (a, b) = (b, a);
                continue;
            }
            else if (c is null)
            {
                c = num;
                if (b < c)
                    (b, c) = (c, b);
                if (a < b)
                    (a, b) = (b, a);
                continue;
            }

            if (a < num)
                (a, b, c) = (num, a, b);
            else if (b < num)
                (b, c) = (num, b);
            else if (c < num)
                c = num;
        }

        return c is null ? a.Value : c.Value;
    }
}
