public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prefix = 1, postfix = 1;
        int[] products = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            products[i] = prefix;
            prefix *= nums[i];
        }

        for (int i = nums.Length-1; i >=0; i--)
        {
            products[i] *= postfix;
            postfix *= nums[i];
        }

        return products; 
    }
}