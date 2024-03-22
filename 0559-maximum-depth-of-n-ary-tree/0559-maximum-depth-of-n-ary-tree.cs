/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root) {
         Queue<Node> queue = new();
        if (root == null)
        {
            return 0;
        }

        int level = 0;
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            
            for (int i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();
                if ((node.children) != null)
                {
                    var tempNode = node;
                    var childrens = tempNode.children;
                    foreach (var childNodes in childrens)
                    {
                        queue.Enqueue(childNodes);
                    }
                }
                
            }
           level++;
        }
        return level;
    }
}