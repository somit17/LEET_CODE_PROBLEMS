public class Solution {
    public int LengthOfLongestSubstring(string s) {
         int length=0,L=0,R=0;
        HashSet<char> set = new();
        while(R<s.Length)
        {
            char currentChar = s[R];
            if (set.Contains(currentChar))
            {
                set.Remove(s[L]);
                L++;
            }
            else
            {
                set.Add(currentChar);
                length = Math.Max(length, R - L + 1);
                R++;
            }
        }
        return length;
    }
}