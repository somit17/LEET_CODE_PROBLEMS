public class Solution {
    public int MaximizeSum(int[] nums, int k) {
        int sum = 0;
        System.Array.Sort(nums);
        int lastVar = nums[nums.Length - 1];
        for (int i = 1; i <= k; i++)
        {
            lastVar = i==1?lastVar:lastVar += 1;
            sum += lastVar;
        }

        return sum;
    }
}