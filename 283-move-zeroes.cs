using System;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (i >= nums.Length - 1)
                i = nums.Length - 2;
            if (nums[i] == 0 && nums[i + 1] != 0)
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                i += 2;
            }
        }
    }
}
