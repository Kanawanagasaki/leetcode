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
    public int MinDepth(TreeNode root)
        => root is null ? 0
        : root.left is not null && root.right is null ? MinDepth(root.left) + 1
        : root.left is null && root.right is not null ? MinDepth(root.right) + 1
        : root.left is not null && root.right is not null
            ? Math.Min(MinDepth(root.left) + 1, MinDepth(root.right) + 1)
        : 1;
}