using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
                map[s[i]]++;
            else map[s[i]] = 1;
            if (map.ContainsKey(t[i]))
                map[t[i]]--;
            else map[t[i]] = -1;
        }

        return map.Values.All(x => x == 0);
    }
}
