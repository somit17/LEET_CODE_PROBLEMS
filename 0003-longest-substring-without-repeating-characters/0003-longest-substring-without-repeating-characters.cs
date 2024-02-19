public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int lPointer = 0, rPointer = 0,maxLength=0;
        HashSet<char> hashSet = new();

        while (rPointer<s.Length)
        {
            char currentChar = s[rPointer];
            if (hashSet.Contains(currentChar))
            {
                hashSet.Remove(s[lPointer]);
                lPointer++;
            }
            else
            {
                hashSet.Add(currentChar);
                maxLength = Math.Max(maxLength, rPointer - lPointer + 1);
                rPointer++;
            }
        }

        return maxLength;
    }
}