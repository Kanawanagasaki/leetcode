/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

namespace leetcode;

using System;
using System.Linq;

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        digits[digits.Length - 1]++;
        var index = Array.IndexOf(digits, 10);
        while (index != -1)
        {
            if (index == 0)
            {
                digits = new int[1].Concat(digits).ToArray();
                index++;
            }

            digits[index] = 0;
            digits[index - 1]++;
            
            index = Array.IndexOf(digits, 10);
        }

        return digits;
    }
}
// @lc code=end

