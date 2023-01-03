using System;
using System.Linq;
using System.Collections.Generic;

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root, int[] prev = null)
    {
        if (root.left is null && root.right is null)
        {
            if (prev is null)
                return new List<string>() { root.val.ToString() };

            return new List<string>() { string.Join("->", prev) + "->" + root.val };
        }

        if (prev is null)
            prev = Array.Empty<int>();

        var ret = new List<string>();
        if (root.left is not null)
        {
            var path = BinaryTreePaths(root.left, prev.Concat(new[] { root.val }).ToArray());
            ret.AddRange(path);
        }
        if (root.right is not null)
        {
            var path = BinaryTreePaths(root.right, prev.Concat(new[] { root.val }).ToArray());
            ret.AddRange(path);
        }

        return ret;
    }
}
