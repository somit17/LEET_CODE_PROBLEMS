public class Solution {
    public string MakeSmallestPalindrome(string s) {
         List<char> charArray = s.ToString().ToList();
        int l = 0, r = s.Length-1;
        while (l < r)
        {
            if (charArray[r] > charArray[l])
            {
                charArray[r] = charArray[l];
            }
            else
            {
                charArray[l] = charArray[r];
            }

            l++;
            r--;
        }

        return new string(charArray.ToArray());
    }
}