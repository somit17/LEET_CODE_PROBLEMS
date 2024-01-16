public class Solution {
    public int[] NumberGame(int[] nums) {
        List<int> numsReturn = new();
        System.Array.Sort(nums);
        int lp = 0, rp = 1;
        while (lp < nums.Length-1 || rp < nums.Length-1)
        { 
            numsReturn.Add(nums[rp]);
            rp += 2;
            numsReturn.Add(nums[lp]);
            lp += 2;
        }
        return numsReturn.ToArray();
    }
}