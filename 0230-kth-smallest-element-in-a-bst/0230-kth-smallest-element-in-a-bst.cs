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
    
    public int KthSmallest(TreeNode root, int k) {
        var dfsResult = DFS(root);
        dfsResult = dfsResult.OrderBy(x => x).ToList();
        return dfsResult[k==0?0:k-1];
    }
    
    public List<int> DFS(TreeNode root)
    {
        if (root == null) return new List<int>();
        List<int> lst = new();
        lst.Add(root.val);
        lst.AddRange(DFS(root.left));
        lst.AddRange(DFS(root.right));
        return lst;
    }
}