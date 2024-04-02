public class Solution {
    public Solution()
    {
        root = new TrieNode();
        
    }
    private TrieNode root;

    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new();
        public bool IsEnd;
        public List<string> products = new List<string>();
    }
      public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        IList<IList<string>> suggestions = new List<IList<string>>();
        TrieNode cur = root;
        bool isPrefixNotFound = false;
        foreach (var item in products)
        {
            Insert(item);
        }

        foreach (char c in searchWord)
        {
            List<string> currentSuggestion = new();
            if (isPrefixNotFound || !cur.children.ContainsKey(c))
            {
                isPrefixNotFound = true;
            }
            else
            {
                cur = cur.children[c];
                currentSuggestion.AddRange(cur.products);
            }
            suggestions.Add(currentSuggestion);
        }

        return suggestions;
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
            curr.products.Add(word);
            curr.products.Sort();
            if (curr.products.Count > 3)
            {
                curr.products.RemoveAt(3);
            }
        }

        curr.IsEnd = true;
    }
}