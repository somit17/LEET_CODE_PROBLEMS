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
    public TreeNode IncreasingBST(TreeNode root) {
       if (root == null)
        {
            return null;
        }

        List<int> result = new();
        InOrderTraversal(root, result);


      TreeNode current = null;
        for(int  i = result.Count-1; i>=0; i--)
        {
            current = new TreeNode(result[i], null, current);
        }
        return current;
    }
    public void InOrderTraversal(TreeNode root, List<int> result)
    {
        if (root != null)
        {
            InOrderTraversal(root.left, result);
            result.Add(root.val);
            InOrderTraversal(root.right, result);
        }
    }
}