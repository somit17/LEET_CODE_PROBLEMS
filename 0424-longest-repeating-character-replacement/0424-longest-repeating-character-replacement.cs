public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0, windowStart = 0;
        int mostFreqLetterCount = 0;
        int[] charCounts = new int[26];
        for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
        {
            charCounts[s[windowEnd] - 'A']++;
            mostFreqLetterCount = Math.Max(mostFreqLetterCount, charCounts[s[windowEnd] - 'A']);
            int lettersToChange = (windowEnd - windowStart + 1) - mostFreqLetterCount;
            if (lettersToChange > k)
            {
                charCounts[s[windowStart ]- 'A']--;
                windowStart++;
            }

            maxLength = Math.Max(maxLength, (windowEnd - windowStart + 1));
        }

        return maxLength;
    }
}