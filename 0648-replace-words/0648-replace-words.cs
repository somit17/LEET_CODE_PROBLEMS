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
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        foreach (var words in dictionary)
        {
            Insert(words);
        }

        StringBuilder finalString = new StringBuilder();
        var splitStrings = sentence.Split(" ");
        foreach (var eachWord in splitStrings)
        {
            var rootWord = FindRootWord(eachWord);
            finalString.Append(rootWord != null ? rootWord : eachWord);
            finalString.Append(" ");
        }
        return finalString.ToString().TrimEnd();  
    }
    private string FindRootWord(string eachWord)
    {
        var current = root;
        StringBuilder sb = new();
        foreach (char ch in eachWord)
        {
            if (!current.Children.ContainsKey(ch))
                return null;
            sb.Append(ch);
            current = current.Children[ch];
            if (current.IsLast)
                return sb.ToString(); //root found
        }

        return null;
    }

    private void Insert(string words)
    {
        var currentNode = root;
        foreach (char ch in words)
        {
            if (!currentNode.Children.ContainsKey(ch))
                currentNode.Children[ch] = new TrieNode();
            currentNode = currentNode.Children[ch];
        }

        currentNode.IsLast = true;
    }
}