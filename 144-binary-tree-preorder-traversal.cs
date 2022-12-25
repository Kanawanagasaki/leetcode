// using System;
// using System.Collections.Generic;
// using System.Linq;

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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var ret = new List<int>();
        var stack = new Stack<TreeNode>();

        while (root is not null)
        {
            ret.Add(root.val);
            stack.Push(root);
            root = root.left;
            while (root is null && stack.TryPop(out var fromStack)) 
                root = fromStack.right;
        }

        return ret;
    }
}