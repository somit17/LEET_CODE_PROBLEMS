public class Solution {
    public int SearchInsert(int[] nums, int key) {
        int left = 0, right = nums.Length - 1;
        int mid = 0;
        while (left <= right)
        {
            mid = (left + right) / 2;
            if (nums[mid] == key)
            {
                return mid;
            }
            else if(nums[mid]>key)
            {
                right = mid - 1;
                
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}