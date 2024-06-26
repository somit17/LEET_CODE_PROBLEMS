public class Solution {
    public string LargestGoodInteger(string num) {
        int  maxDigit = -1;
        for (int i = 2; i < num.Length; i++) {
            if (num[i] == num[i -1] && num[i] == num[i -2]) {
                maxDigit = Math.Max(maxDigit,num[i]-'0');
            }
        }
        return maxDigit == -1? "" : new string(Convert.ToChar(maxDigit + '0'), 3);
    }
}