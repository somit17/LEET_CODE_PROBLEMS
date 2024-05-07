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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
       List<int> leafNodes1 = new(), leafNodes2 = new();
        DFS(root1,leafNodes1); 
        DFS(root2,leafNodes2);
        return leafNodes1.SequenceEqual(leafNodes2);
    }
    public void DFS(TreeNode root, List<int> leafNodes)
    {
        if (root == null) return;
        if(root.left==null && root.right==null)
            leafNodes.Add(root.val);
        DFS(root.left,leafNodes);
        DFS(root.right,leafNodes);
    }
}