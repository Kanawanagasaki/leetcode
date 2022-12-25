// using System;
// using System.Linq;
// using System.Collections.Generic;

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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var order = new List<TreeNode>();
        var stack = new Stack<TreeNode>();

        while (root is not null)
        {
            if(root.left is not null && !order.Contains(root.left))
            {
                stack.Push(root);
                root = root.left;
            }
            else if(root.right is not null && !order.Contains(root.right))
            {
                stack.Push(root);
                root = root.right;
            }
            else
            {
                order.Add(root);
                if(!stack.TryPop(out root))
                    break;
            }
        }

        return order.Select(x => x.val).ToList();
    }
}
