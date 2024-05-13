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
    public IList<int> LargestValues(TreeNode root) {
        List<int> result = new List<int>();
        if (root == null)
            return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count>0)
        {
            int levelCount = queue.Count;
            int currentMax = Int32.MinValue;
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                if(currentNode.left!=null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right!=null)
                    queue.Enqueue(currentNode.right);
                currentMax = Math.Max(currentNode.val, currentMax);
            }
            result.Add(currentMax);
        }

        return result;
    }
}