/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution
{
    public int LengthOfLastWord(string s)
        => s.Trim().Split(" ").Last().Length;
}
// @lc code=end

