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
    public bool IsCompleteTree(TreeNode root) {
        if (root == null) return true;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var previousLevelHadNull = false;
        while(queue.Count > 0) {
            var count = queue.Count;
            var levelHasNull = false;
            for(int i = 0; i < count; i++) {
                var node = queue.Dequeue();
                if(node == null) {
                    levelHasNull = true;
                    continue;
                }
                if(levelHasNull || previousLevelHadNull && node.val != null) {
                    // a null value was found prior to this node, indicating the level isn't
                    // full, and the right-most node isn't the only null one
                    return false;
                }
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
            previousLevelHadNull = levelHasNull;
        }
        return true;
    }
}