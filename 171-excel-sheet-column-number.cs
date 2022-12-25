public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int ret = 0;
        foreach(var ch in columnTitle)
        {
            ret *= 26;
            ret += ch - 'A' + 1;
        }
        return ret;
    }
}