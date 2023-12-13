public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> returnArray = new();
        for (int i = 0; i < words.Length; i++)
        {
            if (IsCharacterFound(words[i], x))
            {
                returnArray.Add(i);
            }
        }

        return returnArray;
    }public  bool IsCharacterFound(string s, char c)
    {
        bool IsCharFound = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                IsCharFound = true;
                break;
            }
        }

        return IsCharFound;
    }
}