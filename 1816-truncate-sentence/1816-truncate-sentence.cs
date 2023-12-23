public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] words = s.Split(new char[] { ' ' });
        StringBuilder finalString = new StringBuilder();
        for (int i = 0; i < k; i++)
        {
             finalString.Append(words[i]+ ' ');
        }

        if (finalString.Length > 0) finalString.Remove(finalString.Length - 1, 1);
        return finalString.ToString();
    }
}