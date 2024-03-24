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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        
        IList<IList<int>> levelOrder = new List<IList<int>>();
        int level = 0;
        Queue<TreeNode> queue = new(); //Node with level
        List<int> levelNodes = new();
        queue.Enqueue((root));
        
        while (queue.Count > 0)
        {
            levelNodes = new();
            int levelCount = queue.Count();
            for (int i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();
                levelNodes.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            level++;
            levelOrder.Add(levelNodes);
        }

        return levelOrder;
    }
}