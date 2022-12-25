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
    public bool IsSameTree(TreeNode a, TreeNode b)
        =>
        (a is null && b is null)
        ||
        (
            a is not null && b is not null && a.val == b.val
            &&
            (
                (a.left is not null && b.left is not null && IsSameTree(a.left, b.left))
                ||
                (a.left is null && b.left is null)
            )
            &&
            (
                (a.right is not null && b.right is not null && IsSameTree(a.right, b.right))
                ||
                (a.right is null && b.right is null)
            )
        );
}
