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
    public bool IsEvenOddTree(TreeNode root) {
      Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int lvl = 0;
        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            List<int> lvlNodes = new List<int>();
            int prevValue = lvl % 2 == 0 ? int.MinValue : int.MaxValue;
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                // Check if the current level meets the conditions
                if ((lvl % 2 == 0 && (currentNode.val % 2 == 0 || currentNode.val <= prevValue)) ||
                    (lvl % 2 != 0 && (currentNode.val % 2 != 0 || currentNode.val >= prevValue)))
                {
                    return false;
                }
                prevValue = currentNode.val;
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
                lvlNodes.Add(currentNode.val);
            }

            lvl++;
        }

        return true;  
    }
}