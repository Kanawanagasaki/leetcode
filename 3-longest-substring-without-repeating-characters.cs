using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        int ptr = 0;
        int ret = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (set.Contains(s[i]))
            {
                ret = Math.Max(ret, set.Count);
                set.Clear();
                ptr++;
                i = ptr;
            }

            set.Add(s[i]);
        }
        return Math.Max(ret, set.Count);
    }
}
