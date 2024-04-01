public class Solution {
    public int LengthOfLastWord(string s) {
        List<string> splitStrings =  s.Split(' ').ToList();
        var whiteSpacedRemoved = splitStrings.Where(x => !string.IsNullOrEmpty(x)).ToList();
        return whiteSpacedRemoved.ElementAt(whiteSpacedRemoved.Count - 1).Length;
    }
}