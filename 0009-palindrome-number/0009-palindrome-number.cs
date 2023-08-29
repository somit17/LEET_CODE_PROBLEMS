public class Solution {
    public bool IsPalindrome(int num) {
       if (num < 0)
        {
            return false; // Negative numbers are not palindromes
        }
        bool isPalindrome = false;
        long orgNum = num,revNum = 0, rem = 0;
        while (num > 0)
        {
            rem = num % 10;
            revNum = revNum * 10 + rem;
            num /= 10;
        }
        return orgNum == revNum;
    }
}