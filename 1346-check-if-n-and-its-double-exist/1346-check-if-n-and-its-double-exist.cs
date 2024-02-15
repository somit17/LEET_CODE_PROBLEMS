public class Solution {
    public bool CheckIfExist(int[] arr) {
System.Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            int target = arr[i] * 2;
            int idx = BS(arr, target);
            if (idx != -1 && idx != i) return true;
        }
        return false;
    }
    public  int BS(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        while (start<=end)
        {
            int mid = (start + end) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return -1;
    }
}