public class Solution {
    public class TrieNode
    {
        public Dictionary<string, TrieNode> children = new();
        public bool isEnd;
    }
     TrieNode root;
    public Solution()
    {
        root = new();
    }
    public void Insert(string[] word)
    {
        TrieNode curr = root;
        foreach (string c in word)
        {
            if (!curr.children.ContainsKey(c))
            {
                curr.children[c] = new TrieNode();
            }  curr = curr.children[c];
        }

        curr.isEnd = true;
    }
    public bool IsSubFolder(string[] prefix)
    {
        TrieNode curr = root;
        foreach (string c in prefix)
        {
            if (!curr.children.ContainsKey(c))
            {
                return false;
            }

            curr = curr.children[c];
            if (curr.isEnd) {
                return true; // Found a sub-folder
            }
        }

        return false;
    }
    public IList<string> RemoveSubfolders(string[] folder) {
       IList<string> result = new List<string>();
        System.Array.Sort(folder);
        foreach (string path in folder)
        {
            string[] components = path.Split('/');
            if (!IsSubFolder(components)) {
                Insert(components);
                result.Add(path);
            }
        }

        return result; 
    }
}