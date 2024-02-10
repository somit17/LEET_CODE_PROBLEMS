public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string firstWord = string.Join("", word1);
        string secondWord = string.Join("", word2);
        return firstWord.Equals(secondWord);
    }
}