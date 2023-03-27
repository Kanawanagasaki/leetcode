public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sPtr = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (s.Length <= sPtr)
                break;
            if (s[sPtr] == t[i])
                sPtr++;
        }
        return sPtr == s.Length;
    }
}