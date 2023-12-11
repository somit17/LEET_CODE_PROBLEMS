public class Solution {
    public int[] BuildArray(int[] nums) {
        List<int> buildArray = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            buildArray.Add(nums[nums[i]]);
        }

        return buildArray.ToArray();
    }
}