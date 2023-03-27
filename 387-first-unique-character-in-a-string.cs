public class Solution
{
    public int FirstUniqChar(string s)
    {
        var chCount = new int[26];
        var chIndex = new int[26];

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int code = s[i] - 'a';
            chCount[code]++;
            chIndex[code] = i;
        }

        int ret = -1;
        for (int i = 0; i < 26; i++)
            if (chCount[i] == 1 && (ret == -1 || chIndex[i] < ret))
                ret = chIndex[i];
        return ret;
    }
}
