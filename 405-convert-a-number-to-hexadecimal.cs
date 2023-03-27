public class Solution
{
    private char[] _hex = new[]
    {
        '0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f'
    };
    public string ToHex(int num)
    {
        if (num == 0) return "0";

        var ret = "";
        uint a = (uint)num;
        while (a > 0)
        {
            ret = _hex[a & 0xF] + ret;
            a >>= 4;
        }
        return ret;
    }
}
