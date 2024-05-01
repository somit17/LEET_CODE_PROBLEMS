public class Solution {
   public int Search(int[] nums, int target)
    {
        int L = 0, R = nums.Length - 1;
        while (L < R)
        {
            int mid = L + (R - L) / 2;
            if (nums[mid] > nums[R]) L = mid + 1;
            else R = mid;
        }

        int pivotIndex = R, index;
        index = BinarySearch(nums, 0, pivotIndex - 1, target);
        if (index != -1) return index;
        index = BinarySearch(nums, pivotIndex, nums.Length - 1, target);
        return index;
    }

    public int BinarySearch(int[] nums, int L, int R, int target)
    {
        while (L <= R)
        {
            int mid = L + (R - L) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                R = mid - 1;
            else
                L = mid + 1;
        }

        return -1;
    }
}