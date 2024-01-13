public class Solution {
    public int RemovePalindromeSub(string s) {
        int minSteps = 1;
        int l = 0, r = s.Length - 1;
        
        while (l <= r)
        {
            if (s[l] != s[r])
            {
                return 2;
            }

            l++;
            r--;
        }
        return minSteps;
    }
}