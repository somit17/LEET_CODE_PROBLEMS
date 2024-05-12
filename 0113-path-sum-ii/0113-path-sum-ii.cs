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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        FillPathSumHelper(root, targetSum, new List<int>(), result);
        return result;
    }

    void FillPathSumHelper(TreeNode root, int targetSum, List<int> temp, IList<IList<int>> result)
    {
        temp.Add(root.val);
        //check if root node
        if (root.left == null && root.right == null)
        {
            if (temp.Sum() == targetSum)
                result.Add(temp);
        }

        if (root.left != null) FillPathSumHelper(root.left, targetSum, new List<int>(temp), result);
        if (root.right != null) FillPathSumHelper(root.right, targetSum, new List<int>(temp), result);
    }
}