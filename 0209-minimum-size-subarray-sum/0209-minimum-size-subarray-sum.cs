public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
       int minWindowSize =Int32.MaxValue;
        int currentWindowSum = 0, windowStart = 0;
        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            currentWindowSum += nums[windowEnd];
            while (currentWindowSum >= target)
            {
                minWindowSize = Math.Min(minWindowSize, windowEnd - windowStart + 1);
                currentWindowSum -= nums[windowStart];
                windowStart++;
            }
        }
if (minWindowSize == Int32.MaxValue) minWindowSize = 0;
        return minWindowSize; 
    }
}