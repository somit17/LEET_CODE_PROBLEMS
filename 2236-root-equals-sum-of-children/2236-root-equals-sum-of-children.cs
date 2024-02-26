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
    public bool CheckTree(TreeNode root) {
      List<int> preOrder =  PreorderToList(root);
       if (preOrder[0] != preOrder[1] + preOrder[2])
       {
           return false;
       }

       return true;  
    }
    public List<int> PreorderToList(TreeNode rootNode)
    {
        List<int> result = new List<int>();
        preOrderTraversal(rootNode, result);
        return result;
    }
    public void preOrderTraversal(TreeNode root,List<int> result)
    {
        if (root != null)
        {
            result.Add(root.val);
           preOrderTraversal(root.left,result);
            preOrderTraversal(root.right,result);
            
        }
        
    }
}