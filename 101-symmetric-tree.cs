public class Solution
{
    public bool IsSymmetric(TreeNode root)
        => Func(root.left, root.right);
    
    private bool Func(TreeNode left, TreeNode right)
    {
        if((left is null && right is not null) || (left is not null && right is null))
            return false;
        if(left is null && right is null)
            return true;
        if(left.val != right.val)
            return false;
        
        return Func(left.left, right.right) && Func(left.right, right.left);
    }
}