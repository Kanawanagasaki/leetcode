using System.Text.RegularExpressions;

public class Solution
{
    public int CountSegments(string s)
        => string.IsNullOrWhiteSpace(s) ? 0 : Regex.Replace(s.Trim(), "  +", " ").Split(" ").Length;
}