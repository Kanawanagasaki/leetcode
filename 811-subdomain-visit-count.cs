/*
 * @lc app=leetcode id=811 lang=csharp
 *
 * [811] Subdomain Visit Count
 */

// @lc code=start

using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public IList<string> SubdomainVisits(string[] cpdomains)
    {
        var dict = new Dictionary<string, int>();
        foreach (var item in cpdomains)
        {
            var args = item.Split(" ");
            var num = int.Parse(args[0]);
            var split = args[1].Split(".");
            for (int i = 0; i < split.Length; i++)
            {
                var domain = string.Join(".", split.Skip(i));

                if(dict.ContainsKey(domain))
                    dict[domain] += num;
                else dict[domain] = num;
            }
        }

        return dict.Select(kv => $"{kv.Value} {kv.Key}").ToList();
    }
}
// @lc code=end

