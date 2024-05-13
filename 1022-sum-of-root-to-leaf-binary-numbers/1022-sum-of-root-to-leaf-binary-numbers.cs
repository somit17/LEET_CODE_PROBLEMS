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
    int res = 0;

    public int SumRootToLeaf(TreeNode root)
    {
        List<List<int>> allPaths = new List<List<int>>();
        List<int> currentPath = new List<int>();
        DFSHelper(root, currentPath, allPaths);
        foreach (var eachPath in allPaths)
        {
            var num = Convert.ToInt32(string.Join("",eachPath), 2);
            res += num;
        }

        return res;
    }

    private void DFSHelper(TreeNode root, List<int> currentPath, List<List<int>> allPaths)
    {
        currentPath.Add(root.val);
        if (root.left == null && root.right == null)
            allPaths.Add(new List<int>(currentPath));
        else
        {
            if (root.left != null) DFSHelper(root.left, currentPath, allPaths);
            if (root.right != null) DFSHelper(root.right, currentPath, allPaths);
        }
        currentPath.RemoveAt(currentPath.Count - 1);
    }
}