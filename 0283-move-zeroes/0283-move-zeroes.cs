public class Solution {
    public void MoveZeroes(int[] nums) {
        int j = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                j = i;
                break;
            }
        }

               if (j != -1){
        for (int i = j + 1; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                j++;
            }
        }
        }
    }
       
}