public class Solution {
   public  string FirstPalindrome(string[] words)
    {
        string palindrome = "";

        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                palindrome = word;
                break;
            }
        }

        return palindrome;
    }

    public  bool IsPalindrome(string word)
    {
        bool isPalidrome = true;
        int startP = 0, endP = word.Length - 1;
        while (endP > startP)
        {
            if (word[startP++] != word[endP--])
            {
                return false;
            }
        }

        return isPalidrome;
    }
}