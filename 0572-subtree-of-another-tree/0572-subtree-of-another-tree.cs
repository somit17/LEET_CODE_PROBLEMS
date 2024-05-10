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
   public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (AreEqualTrees(root, subRoot)) return true;
        if (root.left != null && IsSubtree(root.left, subRoot)) return true;
        if (root.right != null && IsSubtree(root.right, subRoot)) return true;
        return false;
    }
    private bool AreEqualTrees(TreeNode tree0, TreeNode tree1)
    {
        if (tree0 == null && tree1 == null) return true;
        if ((tree0 == null && tree1 != null) || (tree0 != null && tree1 == null)) return false;
        if (tree0.val != tree1.val) return false;
        if (!AreEqualTrees(tree0.left, tree1.left)) return false;
        if (!AreEqualTrees(tree0.right, tree1.right)) return false;
        return true;
    }
}