// using System.Collections;
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
    public IList<int> InorderTraversal(TreeNode root)
    {
        var ret = new List<int>();
        var stack = new Stack<TreeNode>();

        while (root is not null)
        {
            while (root.left is not null)
            {
                stack.Push(root);
                root = root.left;
            }

            ret.Add(root.val);

            if (root.right is not null)
                root = root.right;
            else if(stack.Count > 0)
            {
                do
                {
                    root = stack.Pop();
                    ret.Add(root.val);
                }
                while (root.right is null && stack.Count > 0);
                root = root.right;
            }
            else break;
        }

        return ret;
    }
}
