public class Solution {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new();
        public bool IsLast = false;
    }
    private TrieNode root;
    public Solution()
    {
        root = new();
    }
    public string LongestCommonPrefix(string[] strs) {
        foreach (var s in strs)
            InsertWords(s);
        return StartsWith(root,"");
    }
    void InsertWords(string s)
    {
        var current = root;
        foreach (char ch in s)
        {
            if (!current.Children.ContainsKey(ch))
                current.Children[ch] = new TrieNode();
            current = current.Children[ch];
        }

        current.IsLast = true;
    }

    string StartsWith(TrieNode node,string prefix)
    {
        if (node.Children.Count == 1)
        {
            if(node.IsLast)
            {
                return prefix;
            }
            var ch = node.Children.Keys.First();
            prefix += ch;

            return StartsWith(node.Children[ch], prefix);
        }
        return prefix;
    }
}