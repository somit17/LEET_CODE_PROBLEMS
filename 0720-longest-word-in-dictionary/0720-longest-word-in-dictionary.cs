public class Solution {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new();
        public bool word; //leaf
    }

    private TrieNode root;

    public Solution()
    {
        root = new TrieNode();
    }
    public string LongestWord(string[] words)
    {
        string longest = "";
        foreach (var eachWord in words)
            Insert(eachWord);
        foreach (var word in words)
        {
            if (Search(word))
            {
                if ((longest.Length < word.Length) || 
                    (longest.Length == word.Length && word.CompareTo(longest) < 0))
                    longest = word;
            }
        }

        return longest;
    }


    void Insert(string word)
    {
        var current = root;
        foreach (char ch in word)
        {
            if (!current.children.ContainsKey(ch))
                current.children[ch] = new TrieNode();
            current = current.children[ch];
        }

        current.word = true;
    }

    bool Search(string word)
    {
        var current = root;
        foreach (char ch in word)
        {
            if (!current.children.ContainsKey(ch))
                return false;
            current = current.children[ch];
            if (!current.word)
                return false;
        }

        return true;
    }
}