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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if (depth ==1)
        {
            var newNode = new TreeNode(val);
            newNode.left = root;
            return newNode;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 1;
        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            for (int i = 0; i < levelCount; i++)
            {
                var currentNode = queue.Dequeue();
                if (level == depth - 1)
                {
                    var leftSubTree = currentNode.left;
                    var rightSubTree = currentNode.right;
                    TreeNode newLeftNode = new TreeNode(val);
                    newLeftNode.left = leftSubTree;
                    TreeNode newRightNode = new TreeNode(val);
                    newRightNode.right = rightSubTree;
                    currentNode.left = newLeftNode;
                    currentNode.right = newRightNode;
                }
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
            if (level == depth - 1)
                break;
            level++;
        }

        return root;
    }
}