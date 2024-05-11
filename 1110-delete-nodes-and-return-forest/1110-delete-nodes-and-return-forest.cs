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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        IList<TreeNode> lst = new List<TreeNode>();

        DeleteHelper(root, to_delete, lst);
        if (!to_delete.Contains(root.val))
        {
            lst.Add(root);
        }
        return lst; 
    }

    public TreeNode DeleteHelper(TreeNode root, int[] to_delete, IList<TreeNode> result)
    {
        if(root==null)
            return null;
        root.left = DeleteHelper(root.left, to_delete, result);
        root.right = DeleteHelper(root.right, to_delete, result);
        if (to_delete.Contains(root.val))
        {
            if(root.left!=null) result.Add(root.left);
            if(root.right!=null) result.Add(root.right);
            return null;
        }
        else
        {
            return root;
        }
        
    }
}