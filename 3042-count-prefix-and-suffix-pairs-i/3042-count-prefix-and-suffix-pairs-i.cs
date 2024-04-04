public class TrieNode {
    public Dictionary<char, TrieNode> Children { get; }
    public bool IsEnd { get; set; }

    public TrieNode() {
        Children = new Dictionary<char, TrieNode>();
        IsEnd = false;
    }
}

public class Solution {
    private TrieNode root;

    public Solution()
    {
        root = new TrieNode();
    }
    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;
        for (int i = 0; i < words.Length - 1; i++) {
            for (int j = i + 1; j < words.Length; j++) {
                count += (IsPrefixAndSuffix(words[i], words[j])) ? 1 : 0;
            }
        }
        return count;
    }private bool IsPrefixAndSuffix(string str1, string str2) {
        TrieNode pnode = InsertWord(new TrieNode(), str2);
        TrieNode snode = InsertWord(new TrieNode(), new string(str2.Reverse().ToArray()));
        return SearchNode(pnode, str1) && 
               SearchNode(snode, new string(str1.Reverse().ToArray()));
    }

    private bool SearchNode(TrieNode root, string word) {
        TrieNode current = root;
        foreach (char ch in word) {
            if (!current.Children.ContainsKey(ch)) {
                return false;
            }
            current = current.Children[ch];
        }
        return true;
    }

    private TrieNode InsertWord(TrieNode root, string word) {
        TrieNode node = root;
        foreach (char ch in word) {
            if (!node.Children.ContainsKey(ch)) {
                node.Children[ch] = new TrieNode();
            }
            node = node.Children[ch];
        }
        node.IsEnd = true;
        return root;
    }
}