/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if(root is null)
            return false;
        else if(root.left is not null && root.right is not null)
            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        else if(root.left is not null)
            return HasPathSum(root.left, targetSum - root.val);
        else if(root.right is not null)
            return HasPathSum(root.right, targetSum - root.val);
        else return root.val == targetSum;
    }
}
