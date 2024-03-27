public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
      int res = 0;
        int l = 0;
        int product = 1;
        for (int r = 0; r < nums.Length; r++)
        {
            product *= nums[r];
            while (l<=r && product>=k)
            {
                product = product / nums[l];
                l += 1;
            }

            res += (r - l + 1);
        }

        return res;  
    }
}