public class Solution {
    public int SingleNonDuplicate(int[] nums) {
      int L = 0, R = nums.Length - 1;
        while (L < R)
        {
            int mid = L + (R - L) / 2;
            bool isEven = (R - mid) % 2 == 0;
            if (nums[mid] == nums[mid + 1])
            {
                if (isEven) L = mid;
                else R = mid - 1;
            }
            else if (nums[mid] != nums[mid + 1])
            {
                if (isEven) R = mid;
                else L = mid + 1;
            }
        }

        return nums[R];  
    }
}