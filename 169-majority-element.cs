using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var map = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (map.ContainsKey(num))
                map[num]++;
            else map[num] = 1;
            if (map[num] > nums.Length / 2)
                return num;
        }
        return 0;
    }
}