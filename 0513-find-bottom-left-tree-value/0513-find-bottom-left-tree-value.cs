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
    public int FindBottomLeftValue(TreeNode root) {
        if (root == null)
            return 0;
        int res = 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count>0)
        {
            int levelCount = queue.Count;
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                if (i == 0)
                    res = currentNode.val;
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if(currentNode.right!=null)
                    queue.Enqueue(currentNode.right);
            }

        }

        return res;
    }
}