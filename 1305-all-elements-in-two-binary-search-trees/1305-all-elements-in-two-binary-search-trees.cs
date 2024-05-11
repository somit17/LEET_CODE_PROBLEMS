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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
    {
        IList<int> ans = new List<int>();
        var r1 = DFSHelper(root1);
        var r2 = DFSHelper(root2);
        ans=r1.Concat(r2).ToList();

        return ans.OrderBy(x => x).ToList();
    }

    public List<int> DFSHelper(TreeNode root)
    {
        if (root == null)
            return new List<int>();
        List<int> dfsValues = new();
        dfsValues.Add(root.val);
        dfsValues.AddRange(DFSHelper(root.left));
        dfsValues.AddRange(DFSHelper(root.right));
        return dfsValues;
    }
}