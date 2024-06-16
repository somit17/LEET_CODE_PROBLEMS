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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if(root==null)
        return result;
        Queue<TreeNode> queue=new ();
        queue.Enqueue(root);
       
        while(queue.Count>0){
            int levelC=queue.Count;
            var tempList = new List<int>();
            for(int i=0;i<levelC;i++){
                var currentNode = queue.Dequeue();
                tempList.Add(currentNode.val);
                if(currentNode.left!=null){
                    queue.Enqueue(currentNode.left);
                }
                if(currentNode.right!=null){
                    queue.Enqueue(currentNode.right);
                }
            }
           result.Add(tempList);
        }
        return result;
    }
}