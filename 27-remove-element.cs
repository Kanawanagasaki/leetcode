/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;

        int j = nums.Length - 1;
        while (j >= 0 && nums[j] == val)
            j--;

        for (int i = 0; i < nums.Length && i < j; i++)
        {
            if (nums[i] == val)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                while (j >= 0 && nums[j] == val)
                    j--;
            }
        }

        return j + 1;
    }
}
// @lc code=end

// [3,3,2,2] val = 2