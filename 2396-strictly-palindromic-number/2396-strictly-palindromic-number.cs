public class Solution {
    public bool IsStrictlyPalindromic(int n) {
        int temp = n;
        for (int i = 2; i <= n - 2; i++)
        {
            string numToBase = "";
            while (temp > 0)
            {
                int rem = temp % i;
                temp = temp / i;
                numToBase += rem + temp;
            }
            if (numToBase.Length % 2 == 0)
            {
                int L = 0, R = numToBase.Length - 1;
                while (L < R)
                {
                    if (numToBase[L] != numToBase[R])
                        return false;
                    L++;
                    R--;
                }
            }
            else
                return false;
            temp = n;
        }

        return true;
    }
}