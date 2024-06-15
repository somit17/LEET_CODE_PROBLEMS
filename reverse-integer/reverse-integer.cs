public class Solution {
    public int Reverse(int x) {
        bool isNegative = x<0;
        string str = isNegative ? x.ToString().Substring(1) : x.ToString();
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        
        // Parse the reversed string back to an integer
        if (int.TryParse(reversedStr, out int reversedNum)) {
            // Apply the negative sign if the original number was negative
            return isNegative ? -reversedNum : reversedNum;
        } else {
            // If parsing fails (due to overflow), return 0
            return 0;
        }
    }
}