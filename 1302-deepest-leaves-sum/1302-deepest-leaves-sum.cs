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
    public int DeepestLeavesSum(TreeNode root) {
        if (root == null)
            return 0;
        Queue<(TreeNode, int)> queue = new();
        List<(int, int)> hashMap = new(); //Map value with level
        int level = 0;
        queue.Enqueue((root,level));
        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            for (int i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue().Item1;
                if (node.left != null)
                    queue.Enqueue((node.left,level));
                if (node.right != null)
                    queue.Enqueue((node.right,level));
                hashMap.Add((node.val,level));
            }
            level++;
        }
        return  hashMap.Where(x => x.Item2 == level-1).Select(x=>x.Item1).Sum();  
    }
}