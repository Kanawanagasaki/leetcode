/*
 * @lc app=leetcode id=2351 lang=csharp
 *
 * [2351] First Letter to Appear Twice
 */

// @lc code=start
using System.Collections.Generic;

public class Solution
{
    public char RepeatedCharacter(string s)
    {
        var set = new HashSet<char>();
        foreach(var ch in s)
            if(set.Contains(ch))
                return ch;
            else set.Add(ch);
        
        return s[0];
    }
}
// @lc code=end

