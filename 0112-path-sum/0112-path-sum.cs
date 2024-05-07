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
    public bool HasPathSum(TreeNode root, int targetSum) {
       return DFS(root, targetSum, 0); 
    }
    public bool DFS(TreeNode root, int targetSum, int currenSum)
    {
        if (root == null) return false;
        currenSum += root.val;
        if (currenSum == targetSum && root.left ==null && root.right==null ) return true;//Ensure it is root node
        bool left = DFS(root.left, targetSum, currenSum);
        if (left) return true;
        return DFS(root.right, targetSum, currenSum);
    }
}