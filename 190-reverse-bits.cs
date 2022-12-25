public class Solution
{
    public uint reverseBits(uint n)
    {
        int res = 0;
        for (int shift = 0; shift < 32; shift++)
            res |= ((int)n >> shift & 1) << 31 - shift;
        return (uint)res;
    }
}
