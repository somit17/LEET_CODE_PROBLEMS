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
    private int count = 0;

    public int AverageOfSubtree(TreeNode root)
    {
        DFS(root);
        return count;
    }

    public (int sum, int totalNodes) DFS(TreeNode root)
    {
        if (root == null)
            return (0, 0);
        var LNode = DFS(root.left);
        var RNode = DFS(root.right);
        var currentSum = LNode.sum + RNode.sum + root.val;
        var totalNodes = LNode.totalNodes + RNode.totalNodes + 1;
        var avg = currentSum / totalNodes;
        if (avg == root.val)
        {
            count++;
        }

        return (currentSum, totalNodes);
    }
}