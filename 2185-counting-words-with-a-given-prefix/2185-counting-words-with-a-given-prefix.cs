public class Solution {
    public int PrefixCount(string[] words, string pref) {
           int prefixCount = 0;
        int prefixLength = pref.Length;

        foreach (var word in words)
        {

            prefixCount = word.Length >= prefixLength && word.Substring(0, prefixLength).Equals(pref)
                ? prefixCount + 1
                : prefixCount + 0;

        }
        return prefixCount;
    }
}