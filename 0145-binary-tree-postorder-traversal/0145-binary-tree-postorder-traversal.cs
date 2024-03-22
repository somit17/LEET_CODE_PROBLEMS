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
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        if (root == null) return result;
        
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        
        stack1.Push(root);
        
        while (stack1.Count > 0) {
            TreeNode node = stack1.Pop();
            stack2.Push(node);
            
            if (node.left != null) stack1.Push(node.left);
            if (node.right != null) stack1.Push(node.right);
        }
        
        while (stack2.Count > 0) {
            result.Add(stack2.Pop().val);
        }
        
        return result;
    }
}