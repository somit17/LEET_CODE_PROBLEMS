public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> result=new();
        int carry=1;
        int n=digits.Length;
        for(int i=n-1;i>=0;i--){
            int sum = digits[i]+carry;
            carry = sum/10;
            result.Insert(0,sum%10);
        }
        if(carry>0)
            result.Insert(0,carry);
        return result.ToArray();
    }
}