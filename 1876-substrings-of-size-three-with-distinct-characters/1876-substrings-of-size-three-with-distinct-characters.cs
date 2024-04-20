public class Solution {
    public int CountGoodSubstrings(string s) {
       HashSet<char> hashSet = new();
        int L = 0, R = 0, result = 0;
        while (R < s.Length)
        {
            char currentChar = s[R];
            if (hashSet.Contains(currentChar))
            {
                hashSet.Remove(s[L]);
                L += 1;
            }
            else
            {
                hashSet.Add(currentChar);
                R++;
                if (R - L == 3)
                {
                    result++;
                    hashSet.Remove(s[L]);
                    L++;
                }
            }
        }

        return result; 
    }
}