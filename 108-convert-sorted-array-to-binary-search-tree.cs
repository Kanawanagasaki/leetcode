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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        var center = nums.Length / 2;

        var ret = new TreeNode(nums[center]);
        if (center > 0)
            ret.left = SortedArrayToBST(nums[0..center]);
        if (center < nums.Length - 1)
            ret.right = SortedArrayToBST(nums[(center+1)..]);
        return ret;
    }
}