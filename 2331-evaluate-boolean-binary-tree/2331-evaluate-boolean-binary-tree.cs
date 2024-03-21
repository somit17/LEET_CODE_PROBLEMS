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
    List<int> list = new();
    public bool EvaluateTree(TreeNode root) {
        PostOrderTraversal(root); 
        Stack<int> stack = new(list);
        for(int i=0;i<list.Count();i++)
        {
            if(list[i] == 3 || list[i] ==2)
            {
                int str1 =(stack.Pop());
                int str2 =(stack.Pop());
                
                if(list[i] == 3 )
                    stack.Push((str1&str2));
                    
                else
                    stack.Push(str1|str2);
                
            }
            else
            {
                stack.Push(list[i]);
            }
        }
        return stack.Pop() == 0 ? false : true;
    }public void PostOrderTraversal(TreeNode root)
    {
        if(root == null)
            return;
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            list.Add(root.val);
    }
}