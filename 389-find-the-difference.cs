public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int letterCode = 0;
        foreach(var ch in s)
            letterCode ^= ch;
        foreach(var ch in t)
            letterCode ^= ch;
        return (char)letterCode;
    }
}
