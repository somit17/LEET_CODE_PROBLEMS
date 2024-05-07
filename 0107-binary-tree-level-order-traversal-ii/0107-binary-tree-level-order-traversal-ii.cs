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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
       IList<IList<int>> levelOrder = new List<IList<int>>();
        if (root == null) return levelOrder;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count>0)
        {
            int levelCount = queue.Count;
            var levelList = new List<int>();
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                if(currentNode.left!=null) queue.Enqueue(currentNode.left);
                if(currentNode.right!=null) queue.Enqueue(currentNode.right);
                levelList.Add(currentNode.val);
            }  
            levelOrder.Add(levelList);
        }

        return levelOrder.Reverse().ToList(); 
    }
}