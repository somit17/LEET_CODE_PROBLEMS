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
    public int MaxLevelSum(TreeNode root) {
       if (root == null) return 0;
        Dictionary<int, int> map = new(); //level:sum
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int level = 1;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int lvlCount = queue.Count;
            int currSum = 0;
            for (int i = 0; i < lvlCount; i++)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
                currSum += currentNode.val;
            }

            map.Add(level, currSum);
            level++;
        }

        var result = map.FirstOrDefault();
        foreach (var values in map)
        {
            result = values.Value > result.Value ? values : result;
        }

        return result.Key; 
    }
}