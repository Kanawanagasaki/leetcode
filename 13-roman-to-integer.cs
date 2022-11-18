/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
using System;

public class Solution
{
    private char[] _symbols = new[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
    private int[] _values = new[] { 1, 5, 10, 50, 100, 500, 1000 };

    public int RomanToInt(string s)
    {
        int prevValue = 9999;
        int res = 0;
        foreach(var ch in s)
        {
            int index = Array.IndexOf(_symbols, ch);
            int value = _values[index];

            res += value;

            if(prevValue < value)
                res -= prevValue + prevValue;

            prevValue = value;
        }

        return res;
    }
}
// @lc code=end
