public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int consistentStringCount = 0;
        List<char> allowedChars = allowed.ToList();
        foreach (var word in words)
        {
            bool flag = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (!allowedChars.Contains(word[i]))
                {
                    flag = false;
                }
            }

            if (flag)
            {
                consistentStringCount++;
            }
        }

        return consistentStringCount;
    }
}