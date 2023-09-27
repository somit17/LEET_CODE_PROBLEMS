public class Solution {
    public int SingleNumber(int[] nums) {
         int xor = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            xor = xor ^ nums[i];
        }

        return xor;
    }
}