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
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        if (root == null) return null;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int level = 0;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            List<int> tempNodes = new List<int>();
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
                tempNodes.Add(currentNode.val);
                if(i == levelCount - 1 && level % 2 == 0)
                    queue = ReverseNodes(queue);
                if(i == levelCount - 1)
                    ++level;
            }
        }

        return root;
    }

    private Queue<TreeNode> ReverseNodes(Queue<TreeNode> queue)
    {
        List<int> l2 = new();
        var q2 = new Queue<TreeNode>();
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            q2.Enqueue(node);
            l2.Add(node.val);
        }

        l2.Reverse();
        while (q2.Count > 0)
        {
            var node2 = q2.Dequeue();
            node2.val = l2[0];
            queue.Enqueue(node2);
            l2.RemoveAt(0);
        }

        return queue;
    }
}