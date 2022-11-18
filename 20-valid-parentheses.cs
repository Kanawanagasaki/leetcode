/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new List<char>();

        foreach (var ch in s)
        {
            if (ch == '(' || ch == '[' || ch == '{')
                stack.Add(ch);
            else if (stack.Count == 0)
                return false;
            else if (stack.Last() != ch switch { ')' => '(', ']' => '[', '}' => '{' })
                return false;
            else
                stack.RemoveAt(stack.Count - 1);
        }

        return stack.Count == 0;
    }
}
// @lc code=end
