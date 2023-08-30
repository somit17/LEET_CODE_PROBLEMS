public class Solution {
    public int[] PlusOne(int[] digits) {
         int l = digits.Length;
        for (int i = l - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i] = digits[i] + 1;
                break;
                
            }
            else
            {
                digits[i] = 0;
            }
        }
        
        if (digits[0] == 0)
        {
            int[] newArray = new int[l + 1];
            newArray[0] = 1;
            return newArray;
        }
        return digits;
    }
}