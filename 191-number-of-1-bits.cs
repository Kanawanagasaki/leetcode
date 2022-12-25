public class Solution
{
    public int HammingWeight(uint n)
    {
        int ret = 0;
        for (int i = 0; i < 32; i++)
            ret += (int)n >> i & 1;
        return ret;
    }
}