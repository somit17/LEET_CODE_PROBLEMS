public class Solution {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new();
        public bool IsEnd = false;
    }

    TrieNode root;

    public Solution()
    {
        root = new TrieNode();
    }

    public TrieNode InsertWords(TrieNode root, string s2)
    {
        var current = root;
        foreach (var c in s2)
        {
            if (!current.children.ContainsKey(c))
                current.children[c] = new TrieNode();
            current = current.children[c];
        }

        current.IsEnd = true;
        return root;
    }

    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;
        for (int i = 0; i < words.Length - 1; i++) {
            for (int j = i + 1; j < words.Length; j++) {
                count += (IsPrefixAndSuffix(words[i], words[j])) ? 1 : 0;
            }
        }
        return count;
    }
    private bool StartsWith(TrieNode root, string word)
    {
        TrieNode current = root;
        foreach (char ch in word)
        {
            if (!current.children.ContainsKey(ch))
                return false;
            current = current.children[ch];
        }

        return true;
    }

    public bool IsPrefixAndSuffix(string s1, string s2)
    {
        TrieNode pNode = InsertWords(new TrieNode(), s2);
        TrieNode qNode = InsertWords(new TrieNode(), new string(s2.Reverse().ToArray()));
        return StartsWith(pNode, s1) && StartsWith(qNode, new string(s1.Reverse().ToArray()));
    }
}