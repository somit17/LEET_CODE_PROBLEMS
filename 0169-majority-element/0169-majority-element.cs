public class Solution {
    public int MajorityElement(int[] nums) {
               int count = 0, element = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                count = 1;
                element = nums[i];
            }
            else if (element == nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return element; 
    }
}