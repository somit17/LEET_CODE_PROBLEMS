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
    public bool FindTarget(TreeNode root, int k) {
        var dfsResult = DFS(root);
        int L = 0,R=dfsResult.Count-1;
        dfsResult=dfsResult.OrderBy(x=>x).ToList();
        while (L < R)
        {
            int sum = dfsResult[L] + dfsResult[R];
            if (sum == k) { return true; }
            else if (sum > k) { R--; }
            else { L++; }
        }

        return false;
    }
    
    public List<int> DFS(TreeNode root)
    {
        if (root == null) return new List<int>();
        List<int> res = new List<int>();
        res.Add(root.val);
        res.AddRange(DFS(root.left));
        res.AddRange(DFS(root.right));
        return res;
    }
}