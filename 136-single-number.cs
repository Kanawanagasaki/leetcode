public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int ret = 0;
        foreach(var num in nums)
            ret ^= num;
        return ret;
    }
}