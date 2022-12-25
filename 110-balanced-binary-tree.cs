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
    public bool IsBalanced(TreeNode root)
        => root is null
        || Math.Abs(Height(root.left) - Height(root.right)) <= 1
        && IsBalanced(root.left)
        && IsBalanced(root.right);

    private int Height(TreeNode node)
        => node is null ? 0 : 1 + Math.Max(Height(node.left), Height(node.right));
}