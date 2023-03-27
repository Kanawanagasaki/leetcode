public class Solution
{
    public void ReverseString(char[] s)
    {
        // Array.Reverse(s); // too easy

        char ch;
        for (int i = 0; i < s.Length / 2; i++)
        {
            ch = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = ch;
        }
    }
}