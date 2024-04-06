public class Solution {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new();
        public bool IsEnd = false;
    }
    public TrieNode root;
    public Solution()
    {
        root = new();
    }
    public IList<bool> CamelMatch(string[] queries, string pattern) {
        Insert(pattern);
        IList<bool> res = new List<bool>();
        foreach (string query in queries)
        {
            res.Add(Search(query));
        }

        return res;
    }
        public bool Search(string word)
    {
        TrieNode curr = root;
        foreach (char c in word)
        {
            if (!curr.children.ContainsKey(c) && Char.IsUpper(c))
            {
                return false;
            }

            if (curr.children.ContainsKey(c))
                curr = curr.children[c];
        }
        return curr.IsEnd;
    }

    public void Insert(string word)
    {
        TrieNode curr = root;
        foreach (char c in word)
        {
            if (!curr.children.ContainsKey(c))
            {
                curr.children[c] = new TrieNode();
            }

            curr = curr.children[c];
        }

        curr.IsEnd = true;
    }
}