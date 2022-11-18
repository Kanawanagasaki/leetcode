/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int a = 0, b = 1;
        while (b < nums.Length)
        {
            if (nums[a] == nums[b])
                b++;
            else nums[++a] = nums[b];
        }
        return a + 1;
    }
}
// @lc code=end

