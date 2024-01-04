public class Solution {
    public int MaxProduct(int[] nums) {
        System.Array.Sort(nums);

        int maxNum = nums[nums.Length - 1]-1;
        int secondMaxNum = nums[nums.Length - 2]-1;
        return maxNum*secondMaxNum;
    }
}