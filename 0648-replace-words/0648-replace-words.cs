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
    public string ReplaceWords(IList<string> dictionary, string sentence) {
      foreach (string word in dictionary)
        {
            Insert(word);
        }

        StringBuilder finalString = new();
        string[] splitString = sentence.Split(" ");
    foreach (string sWord in splitString)
        {
            string root = FindRoot(sWord);
            finalString.Append(root != null ? root : sWord);
            finalString.Append(" ");
        }

        return finalString.ToString().TrimEnd();  
    }
    
    public string FindRoot(string word)
    {
        TrieNode curr = root;
        StringBuilder sb = new();
        foreach (char c in word)
        {
            if (!curr.children.ContainsKey(c))
            {
                return null;
            }

            sb.Append(c);
            curr = curr.children[c];
            if (curr.IsEnd)
            {
                return sb.ToString(); // Found a root
            }
        }
        return null; // No root found
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