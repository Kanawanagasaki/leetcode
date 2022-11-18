/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
using System;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            int mid = left + ((right - left) >> 1);

            if (nums[mid] == target)
                return mid;
            if (target < nums[mid])
                right = mid;
            else
                left = mid + 1;
        }

        return nums[left] < target ? left + 1 : left;
    }
}
// @lc code=end

