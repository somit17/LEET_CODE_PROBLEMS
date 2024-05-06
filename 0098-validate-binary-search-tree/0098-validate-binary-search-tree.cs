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
public class Solution {
    public bool IsValidBST(TreeNode root) {
                    return IsValidBSTHelper(root, long.MinValue, long.MaxValue);

    }
    
    
    public bool IsValidBSTHelper(TreeNode root, long minValue, long maxValue)
    {
        if (root == null) return true;
        if (root.val >= maxValue || root.val <= minValue) return false;
        return IsValidBSTHelper(root.left, minValue, root.val) &&
               IsValidBSTHelper(root.right, root.val, maxValue);
    }
}