public class Solution {
    public int FindMin(int[] nums) {
       int L = 0, R = nums.Length - 1;
        while (L<R)
        {
            int mid = L + (R - L) / 2;
            if (nums[mid] > nums[R])
                L = mid + 1;
            else
                R = mid;
        }

        return nums[R]; 
    }
}