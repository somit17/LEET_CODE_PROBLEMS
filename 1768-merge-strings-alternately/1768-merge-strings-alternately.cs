public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var index1 = 0;
        var index2 = 0;
        var sb = new StringBuilder();

        while (index1 < word1.Length || index2 < word2.Length)
        {
            if (index1 < word1.Length)
            {
                sb.Append(word1[index1++]);
            }
            
            if (index2 < word2.Length)
            {
                sb.Append(word2[index2++]);
            }
        }
        
        return sb.ToString();
    }
}