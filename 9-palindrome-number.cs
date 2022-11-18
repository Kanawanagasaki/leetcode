/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
        => x.ToString() == new string(x.ToString().Reverse().ToArray());
}
// @lc code=end

