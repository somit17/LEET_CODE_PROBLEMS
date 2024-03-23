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
        return LeafNodesFromTree(root1).SequenceEqual(LeafNodesFromTree(root2));
    }
    
public List<int> LeafNodesFromTree(TreeNode root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        Stack<TreeNode> stack = new();
        List<int> leafNodes = new();
        stack.Push(root);

        while (stack.Count > 0)
        { var node = stack.Pop();
            if(node.left==null && node.right==null)
                leafNodes.Add(node.val);
               
            if (node.right != null)
            {
                stack.Push(node.right);
            }

            if (node.left != null)
            {
                stack.Push(node.left);
            }
               
        }

        return leafNodes;
    }
}