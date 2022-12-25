public class Solution
{
    public string ConvertToTitle(int num)
    {
        string ret = "";

        while (num > 0)
        {
            num--;
            ret = (char)('A' + num % 26) + ret;
            num /= 26;
        }

        return ret;
    }
}