public class Solution {
    public int MissingNumber(int[] nums) {
         int n = nums.Length;
        int sumOfNN = 0, sumOfNo = 0;
        sumOfNN = (n * (n + 1)) / 2;
        for (int i = 0; i < nums.Length; i++)
        {
            sumOfNo += nums[i];
        }

        return sumOfNN - sumOfNo;
    }
}