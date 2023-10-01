public class Solution {
    public void SortColors(int[] nums) {
        int low = 0, mid = 0, high = nums.Length - 1,n=nums.Length;

        while(mid<=high)
        {
            if (nums[mid] == 0)
            {
                (nums[mid], nums[low]) = (nums[low], nums[mid]);
                mid++;
                low++;
            }
           else  if (nums[mid] == 1) { mid++; }
           else
            {
                (nums[mid], nums[high]) = (nums[high], nums[mid]);
                high--;
            }
        }
    }
}