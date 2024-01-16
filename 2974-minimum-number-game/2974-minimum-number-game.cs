public class Solution {
    public int[] NumberGame(int[] nums) {
        List<int> numsReturn = new();
        System.Array.Sort(nums);
        List<int> aliceStack = new();
        List<int> bobStack = new();
        for (int i = 0; i < nums.Length; i+=2)
        {
            aliceStack.Add(nums[i]);
        }
        for (int i = 1; i < nums.Length; i+=2)
        {
            bobStack.Add(nums[i]);
        }

        for (int i = 0; i < nums.Length/2; i++)
        {
            numsReturn.Add(bobStack[i]);
            numsReturn.Add(aliceStack[i]);
        }
        return numsReturn.ToArray();
    }
}