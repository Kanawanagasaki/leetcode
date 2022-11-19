/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 */

// @lc code=start
public class Solution
{
    public int MySqrt(int x)
    {
        long i = 1;
        while(i * i <= x)
            i++;
        return (int)(i - 1);
    }
}
// @lc code=end

