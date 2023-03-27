public class Solution
{
    public int ArrangeCoins(int n)
    {
        int i = 0;
        long j = 0;
        while (j <= n)
        {
            i++;
            j += i;
        }
        return i - 1;
    }
}