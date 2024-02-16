public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder finalString = new();
        foreach (var eachChar in s)
        {
            if (Char.IsLetterOrDigit(eachChar))
            {
                finalString.Append(Char.ToLower(eachChar) );
            }
        }

        int start = 0, end = finalString.Length-1;

        while (start<=end)
        {
            if (finalString[start]!=finalString[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}