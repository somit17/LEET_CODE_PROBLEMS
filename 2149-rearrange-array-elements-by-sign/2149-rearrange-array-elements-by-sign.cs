public class Solution {
    public int[] RearrangeArray(int[] nums) {
            int[] returnArray = new int[nums.Length];
        int posIndex = 0, negIndex = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                returnArray[posIndex] = nums[i];
                posIndex += 2;
            }
            else
            {
                returnArray[negIndex] = nums[i];
                negIndex += 2;
            }
        }
        return returnArray;
    }
}