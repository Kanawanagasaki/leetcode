/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
using System;
using System.Numerics;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var num = ToBigInt(a) + ToBigInt(b);
        var ret = "";
        while (num > 0)
        {
            ret = (num & 1) + ret;
            num >>= 1;
        }
        return ret == "" ? "0" : ret;
    }

    private BigInteger ToBigInt(string a)
    {
        var ret = new BigInteger();
        foreach (var ch in a)
        {
            ret <<= 1;
            ret += ch == '1' ? 1 : 0;
        }
        return ret;
    }
}
// @lc code=end

