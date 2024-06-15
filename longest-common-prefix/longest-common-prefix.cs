public class Solution {
    public class TrieNode{
        public Dictionary<char,TrieNode> Children=new();
        public bool IsWord=false;
    }
    public TrieNode root;
    public Solution(){
      root=new TrieNode();  
    }
    public string LongestCommonPrefix(string[] strs) {
        foreach(var s in strs){
            Insert(s);
        }
        return StartsWith(root,"");
    }
    public void Insert(string s){
        var current=root;
        foreach(var ch in s){
            if(!current.Children.ContainsKey(ch)){
                current.Children[ch]=new TrieNode();
            }
            current = current.Children[ch];
        }
        current.IsWord=true;
    }
    public string StartsWith(TrieNode root,string prefix){
        if(root.Children.Count==1){
            if(root.IsWord){
                return prefix;
            }
            var ch = root.Children.Keys.First();
            prefix +=ch;
            return StartsWith(root.Children[ch], prefix);
        }
        return prefix;
    }
    
}