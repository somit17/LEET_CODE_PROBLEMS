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
    
    IList<int> lst = new List<int>();
    public IList<int> RightSideView(TreeNode root)
    {
        if (root == null)
            return lst;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count() > 0)
        {
            int levelCount = queue.Count;
            int rightMost = 0;
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                rightMost = currentNode.val;
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
            lst.Add(rightMost);
        }
        return lst;
    }
}