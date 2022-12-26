using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
            return new List<string>();

        var ret = new List<string>();
        var start = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] != 1)
            {
                if (start == i - 1)
                    ret.Add(nums[start].ToString());
                else
                    ret.Add($"{nums[start]}->{nums[i - 1]}");
                start = i;
            }
        }

        if (start == nums.Length - 1)
            ret.Add(nums[start].ToString());
        else
            ret.Add($"{nums[start]}->{nums[nums.Length - 1]}");

        return ret;
    }
}