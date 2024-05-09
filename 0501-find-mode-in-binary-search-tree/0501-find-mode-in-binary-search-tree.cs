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
    int maxFreq = 1;
    Dictionary<int, int> map = new();

    public int[] FindMode(TreeNode root)
    {
        List<int> res = new();
        var dfs = DFSHelper(root);
        foreach (var pair in dfs)
        {
            if (pair.Value == maxFreq)
            {
                res.Add(pair.Key);
            }
        }

        return res.ToArray();
    }
        public Dictionary<int, int> DFSHelper(TreeNode root)
    {
        if (root == null)
            return new Dictionary<int, int>();
        if (map.ContainsKey(root.val))
        {
            map[root.val]++;
            maxFreq = Math.Max(map[root.val], maxFreq);
        }
        else
            map.Add(root.val, 1);
        DFSHelper(root.left);
        DFSHelper(root.right);
        return map;
    }
}