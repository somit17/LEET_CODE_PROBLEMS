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
    public TreeNode PruneTree(TreeNode root) {
       if (root == null)
            return null;
        if (!isOnePresent(root.left))
            root.left = null;
        if (!isOnePresent(root.right))
            root.right = null;
        PruneTree(root.left);
        PruneTree(root.right);
        if (root.left == null && root.right == null && root.val == 0)
            return null;
        return root; 
    }
    bool isOnePresent(TreeNode node)
    {
        if (node == null)
            return false;
        if (node.val == 1)
            return true;
        return isOnePresent(node.left) || isOnePresent(node.right);
    }
}