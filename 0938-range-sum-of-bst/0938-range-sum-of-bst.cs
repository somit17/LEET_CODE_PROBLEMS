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
    private List<int> l = new();
    public int RangeSumBST(TreeNode root, int low, int high) {
    int rangeSum = 0;
        InOrderTraversal(root);
        foreach (var eachNodeVal in l)
        {
            if (eachNodeVal >= low && eachNodeVal <= high)
            {
                rangeSum += eachNodeVal;
            }
        }

        return rangeSum;
    }
    public void InOrderTraversal(TreeNode root)
    {
        if (root != null)
        {
            InOrderTraversal(root.left);
            l.Add(root.val);
            InOrderTraversal(root.right);
        }
    }
}