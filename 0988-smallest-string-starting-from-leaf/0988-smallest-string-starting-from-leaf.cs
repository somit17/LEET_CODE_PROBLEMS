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
    public string SmallestFromLeaf(TreeNode root)
    {
        List<List<int>> allPaths = new List<List<int>>();
        var currentPath = new List<int>();
        AllPathLeafToRoot(root, currentPath, allPaths);
        Dictionary<int, char> charDictionary = new Dictionary<int, char>();
        for (int i = 0; i < 26; i++)
        {
            charDictionary[i] = (char)('a' + i);
        }

        List<List<string>> allStringPaths = new List<List<string>>();
        foreach (var eachPath in allPaths)
        {
            var temp = new List<string>();
            foreach (var charElement in eachPath)
            {
                temp.Insert(0, charDictionary[charElement].ToString());
            }

            allStringPaths.Add(temp);
        }

        allStringPaths = allStringPaths.OrderBy(x => string.Join("", x)).ToList();
        StringBuilder s = new StringBuilder(string.Join("",allStringPaths[0]));
        return s.ToString();
    }

    public void AllPathLeafToRoot(TreeNode root, List<int> currentPath, List<List<int>> paths)
    {
        currentPath.Add(root.val);
        if (root == null)
            return;
        if (root.left == null && root.right == null)
            paths.Add(new List<int>(currentPath));
        if (root.left != null)
            AllPathLeafToRoot(root.left, currentPath, paths);
        if (root.right != null)
            AllPathLeafToRoot(root.right, currentPath, paths);
        currentPath.RemoveAt(currentPath.Count - 1);
    }
}