public class Solution {
    public string SortSentence(string s) {
        SortedDictionary<int, string> hashMap = new();
        string[] words = s.Split(new char[] { ' ' });
        foreach (var word in words)
        {
            int pos = word[word.Length - 1] - '0';
            var eachWord = new String(word.Where(x => Char.IsLetter(x)).ToArray());
            hashMap.Add(pos, eachWord);
        }

        StringBuilder finalString = new StringBuilder();
        foreach (var value in hashMap.Values)
        {
            finalString.Append(value + ' ');
        }

        if (finalString.Length > 0) finalString = finalString.Remove(finalString.Length - 1, 1);
        return finalString.ToString();
    }
}