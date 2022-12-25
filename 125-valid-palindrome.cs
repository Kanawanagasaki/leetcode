public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = new string(s.Where(x => char.IsLetterOrDigit(x)).ToArray()).ToLower();
        return s == new string(s.Reverse().ToArray());
    }
}