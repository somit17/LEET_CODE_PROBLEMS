public class Solution {
    public bool IsAnagram(string s, string t) {
         // Anagrams must be of the same length
        if (s.Length != t.Length) {
            return false;
        }
        var hashMap = new Dictionary<char,int>();
        foreach(var ch in s){
            if(!hashMap.ContainsKey(ch)){
                hashMap[ch]=1;
            }else{
                hashMap[ch]++;
            }
        }
        foreach(var ch in t){
            if(hashMap.ContainsKey(ch) && hashMap[ch]>0){
                hashMap[ch]--;
            }else{
                return false;
            }
        }
        return true;
    }
}