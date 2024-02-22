public class Solution {
    public int LongestOnes(int[] nums, int k) {
     int left = 0,zeroCount=0,maxCount=0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0) zeroCount++;
            while (zeroCount>k)
            {
                if (nums[left] == 0)
                {
                    zeroCount--;
                }

                left++;
            }

            maxCount = Math.Max(maxCount, right - left + 1);

        }
        

        return maxCount;   
    }
}