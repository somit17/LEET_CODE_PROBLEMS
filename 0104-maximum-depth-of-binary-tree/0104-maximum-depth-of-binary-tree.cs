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
    public int MaxDepth(TreeNode root) {
        TreeNode curr;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root == null) return 0;

        queue.Enqueue(root);
        int level = 0;
        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                curr = queue.Dequeue();
                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            
            }level++;
        }

        return level;
    }
    
    
}