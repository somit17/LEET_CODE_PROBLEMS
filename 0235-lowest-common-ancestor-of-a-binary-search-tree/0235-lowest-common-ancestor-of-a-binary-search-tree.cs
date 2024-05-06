/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
       if (root == null) return root;
        if (root == p || root == q)
            return root;

        //Left side 
        TreeNode leftN = LowestCommonAncestor(root.left, p, q);
        TreeNode rightN = LowestCommonAncestor(root.right, p, q);
        if (leftN != null && rightN != null) return root;
        if (leftN != null) return leftN;
        return rightN; 
    }
}