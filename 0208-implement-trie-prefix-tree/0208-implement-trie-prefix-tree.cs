public class Trie {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new();
        public bool word; //isleaf
    }
 private TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach (char c in word)
        {
            if (!curr.children.ContainsKey(c))
            {
                curr.children[c] = new TrieNode();
            }

            curr = curr.children[c];
        }

        curr.word = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;
        foreach (char c in word)
        {
            if (!curr.children.ContainsKey(c))
            {
                return false;
            }

            curr = curr.children[c];
        }

        return curr.word;
    }
    
    public bool StartsWith(string prefix) {
       TrieNode curr = root;
        foreach (char c in prefix)
        {
            if (!curr.children.ContainsKey(c))
            {
                return false;
            }

            curr = curr.children[c];
        }

        return true;  
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */