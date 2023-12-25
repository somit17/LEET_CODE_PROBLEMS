public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
         StringBuilder matchString = new();
        foreach (var word in words)
        {
            matchString.Append(word[0]);
        }

        if (matchString.ToString().Equals(s))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}