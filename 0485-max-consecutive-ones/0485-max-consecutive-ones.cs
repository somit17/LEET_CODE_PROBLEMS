public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
          int count = 0, maxCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1) count++;
            else count = 0;
            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}