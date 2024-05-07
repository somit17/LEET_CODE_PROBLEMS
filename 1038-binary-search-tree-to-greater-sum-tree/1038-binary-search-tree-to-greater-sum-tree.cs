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
    public TreeNode BstToGst(TreeNode root)
    {
        List<(int, int)> map = new List<(int, int)>(); //Map node with highest sum
        var dfsResult = DFSIterative(root);
        dfsResult = dfsResult.OrderBy(x => x).ToList();
        foreach (var element in dfsResult)
        {
            int L = dfsResult.IndexOf(element), R = dfsResult.Count-1,total=dfsResult.Count-1;
            int currentSum = 0;
            while (L <= R)
            {
                currentSum += dfsResult[L]<=dfsResult[R]? dfsResult[R]:0;
                R--;
            }
            map.Add((element,currentSum));
        }

        foreach (var lst in map)
        {
            SearchReplace(ref root, lst);
        }
        return root;
    }

    public List<int> DFSIterative(TreeNode root)
    {
        if (root == null) return new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> dfsResult = new List<int>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var poppedNode = stack.Pop();
            dfsResult.Add(poppedNode.val);
            if (poppedNode.right != null)
                stack.Push(poppedNode.right);
            if (poppedNode.left != null)
                stack.Push(poppedNode.left);
           
        }

        return dfsResult;
    }

    public TreeNode SearchReplace(ref TreeNode root, (int, int) map)
    {
        if (root == null) return null;
        if (root.val == map.Item1)  root.val = map.Item2;
        SearchReplace(ref root.left, map);
        SearchReplace(ref root.right, map);
        return root;
    }
}