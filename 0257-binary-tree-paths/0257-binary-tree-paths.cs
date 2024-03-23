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
    private List<string> finalPath = new();
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        PreOrderTraversalHelper(root,"");
        return finalPath;
    }

    
    public void PreOrderTraversalHelper(TreeNode node,string path)
    {
        if (node.left == null && node.right==null)
        {
            path += $"{node.val}";
            finalPath.Add(path);
            return; 
        }
        path += $"{node.val}->";
        if(node.left!=null)
        PreOrderTraversalHelper(node.left,path);
        if (node.right!=null)
        PreOrderTraversalHelper(node.right,path);
    }
}